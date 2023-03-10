using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TickeTac.Models;

namespace TickeTac.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    DbSet<Category> Categories { get; set; }
    DbSet<Client> Clients { get; set; }
    DbSet<Event> Events { get; set; }
    DbSet<EventOwner> EventOwners { get; set; }
    DbSet<EventReview> EventReviews { get; set; }
    DbSet<StatusEvent> StatusEvents { get; set; }
    DbSet<SubCategory> SubCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Many-to-many EventReview
        builder.Entity<EventReview>().HasKey(
            r => new { r.EventId, r.ClientId }
        );

        builder.Entity<EventReview>()
            .HasOne(er => er.Client)
            .WithMany(c => c.ClientMadeReview)
            .HasForeignKey(er => er.ClientId);
            
        builder.Entity<EventReview>()
            .HasOne(er => er.Event)
            .WithMany(e => e.ReviewReceived)
            .HasForeignKey(er => er.EventId);
        #endregion
    }
}
