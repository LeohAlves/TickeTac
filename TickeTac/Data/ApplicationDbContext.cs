using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TickeTac.Models;


namespace TickeTac.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventOwner> EventOwners { get; set; }
    public DbSet<EventReview> EventReviews { get; set; }
    public DbSet<StatusEvent> StatusEvents { get; set; }

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
                Name="Usuario",
                NormalizedName= "USUÁRIO"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString() ,
                Name="Organizador",
                NormalizedName= "ORGANIZADOR"
            }
        };
        builder.Entity<IdentityRole>().HasData(listRoles);
        #endregion

        #region seed User Admin
        var userId = Guid.NewGuid().ToString();
        var hash = new PasswordHasher<AppUser>();
        builder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = userId,
                    Name = "Leonardo",
                    UserName = "Admin@TickeTac.com",
                    NormalizedUserName = "ADMIN@TICKETAC.COM",
                    Email = "Admin@TickeTac.com",
                    NormalizedEmail = "ADMIN@TICKETAC.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString(),
                    ProfilePicture = ""
                }
        );
        builder.Entity<IdentityUserRole<string>>().HasData(
         new IdentityUserRole<string>()
         {
             UserId = userId,
             RoleId = listRoles[0].Id
         }
        );
        #endregion

        #region seed user usuario
        var usuarioId = Guid.NewGuid().ToString();
        builder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = usuarioId,
                    Name = "Kaique",
                    UserName = "Kaka@TickeTac.com",
                    NormalizedUserName = "KAKA@TICKETAC.COM",
                    Email = "Kaique@TickeTac.com",
                    NormalizedEmail = "KAIQUE@TICKETAC.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString(),
                    ProfilePicture = ""
                }
        );
        builder.Entity<IdentityUserRole<string>>().HasData(
         new IdentityUserRole<string>()
         {
             UserId = usuarioId,
             RoleId = listRoles[1].Id
         }
        );
        #endregion

        #region seed category

        List<Category> listCategory = new List<Category>()
        {
            new Category()
            {
                Id = 1,
                Name = "Feiras e exposições Arte",
                Img = "https://cdn-icons-png.flaticon.com/512/1756/1756784.png"
            },
            new Category()
            {
                Id = 2,
                Name = "Leilões ",
                Img = "https://cdn-icons-png.flaticon.com/512/3399/3399161.png"
            },
            new Category()
            {
                Id = 3,
                Name = "Esporte",
                Img = "https://cdn-icons-png.flaticon.com/512/33/33736.png"
            },
            new Category()
            {
                Id = 4,
                Name = "Musica",
                Img = "https://i.pinimg.com/originals/ca/16/fd/ca16fd3428cd473af9301ff50894f456.png"
            },

            new Category()
            {
                Id = 5,
                Name = "Games",
                Img = "https://cdn-icons-png.flaticon.com/512/1101/1101820.png"
            },

            new Category()
            {
                Id = 6,
                Name = "Stand 'Up",
                Img = "https://cdn2.iconfinder.com/data/icons/theater-stage-performers/287/artist-show-performance-006-512.png"
            },
            new Category()
            {
                Id = 7,
                Name = "Anime",
                Img = "https://static.thenounproject.com/png/34322-200.png"
            },
            new Category()
            {
                Id = 8,
                Name = "Formatura",
                Img = "https://cdn-icons-png.flaticon.com/512/42/42972.png"
            }

        };
        builder.Entity<Category>().HasData(listCategory);


        #endregion

        #region seed status event
        List<StatusEvent> listStatusEvent = new List<StatusEvent>()
        {
                new StatusEvent()  
            {
                Id = 1,
                Name =  "Concluido"
            },

                new StatusEvent()  
            {
                Id = 2,
                Name =  "Em andamento"
            },            
                new StatusEvent()  
            {
                Id = 3,
                Name =  "Confirmado"
            },
                new StatusEvent()  
            {
                Id = 4,
                Name =  "Cancelado"
            },


        };
        builder.Entity<StatusEvent>().HasData(listStatusEvent);

        #endregion

        #region seed events 

        List<Event> listEvent = new List<Event>()
        {
            new Event()
            {
                Id = 1,
                Name = "Show de Rock do Gallo",
                ContactPhone = "14991115478",
                Price = 150.99m,
                EventDateBegin = DateTime.Parse("28/12/2023 12:00"),
                EventDateEnd = DateTime.Parse("01/01/2024 18:00"),
                Description = "Evento de rock que será realizado em Barra Bonita, com grandes artistas musicais como Gallo e Edriano",
                Image = "",
                ContactEmail = "gallo@email.com",
                MoreInfo = "",
                State = "São Paulo",
                City = "Barra Bonita",
                District = "Nova Barra",
                PublicSpace = "Nem lembro o que é",
                Cep = "1234567891234",
                CategoryId = 4,
                EventOwnerId = 1,
                StatusEventId = 2
            }
        };
        builder.Entity<Event>().HasData(listEvent);

        #endregion

        #region seed eventowner

        List<EventOwner> listEventOwner = new List<EventOwner>()
        {
            new EventOwner()
            {
                Id = 1,
                Name = "José Gallo",
                CpfCnpj = "00100200304",
                UserId = usuarioId
            }
        };

        builder.Entity<EventOwner>().HasData(listEventOwner);

        #endregion
    }
}
