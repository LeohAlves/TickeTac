using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TickeTac.Models;

namespace TickeTac.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    DbSet<Category> categories { get; set; }
    DbSet<Client> Clients { get; set; }
    DbSet<Event> Events { get; set; }
    DbSet<Review> Reviews { get; set; }
    DbSet<StatusEvent> StatusEvents { get; set; }
    DbSet<SubCategory> SubCategories { get; set; }
}
