using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TickeTac.Models;
using Microsoft.AspNetCore.Identity;


namespace TickeTac.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventOwner> EventOwners { get; set; }
    public DbSet<EventReview> EventReviews { get; set; }
    public DbSet<StatusEvent> StatusEvents { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Many-to-many EventReview
        builder.Entity<EventReview>().HasKey(
            r => new { r.EventId, r.UserId }
        );

        builder.Entity<EventReview>()
            .HasOne(er => er.User)
            .WithMany(c => c.UserMadeReview)
            .HasForeignKey(er => er.UserId);
            
        builder.Entity<EventReview>()
            .HasOne(er => er.Event)
            .WithMany(e => e.ReviewReceived)
            .HasForeignKey(er => er.EventId);
        #endregion
    }
    
    #region Seed Roles

        List<IdentityRole> listRoles = new()
        {
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString() ,
                Name="Administrador",
                NormalizedName= "ADMINISTRADOR"

            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString() ,
                Name="Usuário",
                NormalizedName= "USUÁRIO"

            }
        };
        
        #endregion
}
