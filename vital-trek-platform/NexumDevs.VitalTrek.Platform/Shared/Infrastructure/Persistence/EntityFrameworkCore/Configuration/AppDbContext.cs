using NexumDevs.VitalTrek.Platform.Monitoring.Domain.Model.Aggregate;
using NexumDevs.VitalTrek.Platform.Monitoring.Domain.Model.ValueObjects;
using NexumDevs.VitalTrek.Platform.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration.Extensions;
using NexumDevs.VitalTrek.Platform.Shared.Infrastructure.Persistence.EntityFrameworkCore.Interceptors;
using Microsoft.EntityFrameworkCore;

namespace NexumDevs.VitalTrek.Platform.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;

/// <summary>
///     Application database context for the Learning Center Platform
/// </summary>
/// <param name="options">
///     The options for the database context
/// </param>
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    /// <inheritdoc />
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        // Apply audit timestamp interceptor for all IAuditableEntity implementations
        builder.AddInterceptors(new AuditableEntityInterceptor());
        base.OnConfiguring(builder);
    }

    /// <summary>
    ///     On creating the database model
    /// </summary>
    /// <remarks>
    ///     This method is used to create the database model for the application.
    /// </remarks>
    /// <param name="builder">
    ///     The model builder for the database context
    /// </param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Incident>().HasKey(i => i.Id);
        builder.Entity<Incident>().Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();

        builder.Entity<Incident>()
            .Property(i => i.ExpeditionId)
            .IsRequired();

        builder.Entity<Incident>()
            .Property(i => i.ReportedBy)
            .IsRequired();

        builder.Entity<Incident>()
            .Property(i => i.Description)
            .IsRequired()
            .HasMaxLength(500);

        builder.Entity<Incident>()
            .Property(i => i.Severity)
            .IsRequired()
            .HasMaxLength(50);

        builder.Entity<Incident>()
            .Property(i => i.Status)
            .IsRequired()
            .HasMaxLength(50);

        builder.Entity<Incident>()
            .Property(i => i.ReportedAt)
            .IsRequired()
            .HasMaxLength(100);

        builder.UseSnakeCaseNamingConvention();
    }
}