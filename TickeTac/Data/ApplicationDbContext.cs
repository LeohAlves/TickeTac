using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TickeTac.Models;


namespace TickeTac.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
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
                    UserName = "Leo@TickeTac.com",
                    NormalizedUserName = "LEO@TICKETAC.COM",
                    Email = "Leonardo@TickeTac.com",
                    NormalizedEmail = "LEONARDO@TICKETAC.COM",
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
                Img = "data:image/png;base64,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"
            },
            new Category()
            {
                Id = 2,
                Name = "Leilões ",
                Img = "data:image/png;base64,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"
            },
            new Category()
            {
                Id = 3,
                Name = "Esporte",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8_efAfhxkSd5jXvxk6G7MZwriXTk_FuFswg&usqp=CAU"
            },
            new Category()
            {
                Id = 4,
                Name = "Musica",
                Img = "https://img.freepik.com/vetores-premium/logotipo-do-evento-do-festival-de-musica-icone-ilustracao-identidade-da-marca_7109-977.jpg?w=2000"
            },

            new Category()
            {
                Id = 5,
                Name = "Games",
                Img = "data:image/png;base64,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"
            },

            new Category()
            {
                Id = 6,
                Name = "Stand 'Up",
                Img = "data:image/png;base64,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"
            },

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
                EventId = 1,
                UserId = usuarioId
            }
        };

        builder.Entity<EventOwner>().HasData(listEventOwner);

        #endregion
    }
}
