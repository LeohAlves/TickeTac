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
    public DbSet<State> States { get; set; }
    public DbSet<City> Cities { get; set; }
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
                    Name = "Admin",
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

        // INICIO DA SEED DE USUARIOS ---------------------------------------

        #region seed user usuario
        var galloId = Guid.NewGuid().ToString();
        builder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = galloId,
                    Name = "José Gallo",
                    UserName = "Gallo@Email.com",
                    NormalizedUserName = "GALLO@EMAIL.COM",
                    Email = "Gallo@Email.com",
                    NormalizedEmail = "GALLO@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString(),
                    ProfilePicture = "https://avatars.githubusercontent.com/u/12284966?v=4"
                }
        );
        builder.Entity<IdentityUserRole<string>>().HasData(
         new IdentityUserRole<string>()
         {
             UserId = galloId,
             RoleId = listRoles[1].Id
         }
        );

        var kaiqueId = Guid.NewGuid().ToString();
        builder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = kaiqueId,
                    Name = "Kaique",
                    UserName = "Kai@Email.com",
                    NormalizedUserName = "KAI@EMAIL.COM",
                    Email = "Kai@Email.com",
                    NormalizedEmail = "KAI@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString(),
                    ProfilePicture = "https://avatars.githubusercontent.com/u/99449012?v=4"
                }
        );
        builder.Entity<IdentityUserRole<string>>().HasData(
         new IdentityUserRole<string>()
         {
             UserId = kaiqueId,
             RoleId = listRoles[1].Id
         }
        );

        builder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = 1.ToString(),
                    Name = "Leonardo",
                    UserName = "Leo@Email.com",
                    NormalizedUserName = "LEO@EMAIL.COM",
                    Email = "Leo@Email.com",
                    NormalizedEmail = "LEO@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString(),
                    ProfilePicture = "https://avatars.githubusercontent.com/u/99449193?v=4"
                }
        );
        builder.Entity<IdentityUserRole<string>>().HasData(
         new IdentityUserRole<string>()
         {
             UserId = 1.ToString(),
             RoleId = listRoles[1].Id
         }
        );

        #endregion

        // FIM DA SEED DE USUARIOS ---------------------------------------

        #region seed eventowner

        List<EventOwner> listEventOwner = new List<EventOwner>()
        {
            new EventOwner()
            {
                Id = 1,
                Name = "José Gallo",
                CpfCnpj = "00100200304",
                UserId = "1"
            },
            new EventOwner()
            {
                Id = 2,
                Name = "Kaique",
                CpfCnpj = "09876543211",
                UserId = "2"
            },
            new EventOwner()
            {
                Id = 3,
                Name = "Leonardo",
                CpfCnpj = "24307069030",
                UserId = "3"
            }
        };
        builder.Entity<EventOwner>().HasData(listEventOwner);
        #endregion

        #region seed category

        List<Category> listCategory = new List<Category>()
        {
            new Category()
            {
                Id = 1,
                Name = "Feiras e exposições de Arte",
                Img = "https://cdn-icons-png.flaticon.com/512/1756/1756784.png"
            },
            new Category()
            {
                Id = 2,
                Name = "Leilões",
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
                Name = "Música",
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
                Name = "Entretenimento",
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

        #region seed state
        List<State> listState = new List<State>(){
                new State() { Id = 1, Name = "AC" },
                new State() { Id = 2, Name = "AL" },
                new State() { Id = 3, Name = "AP" },
                new State() { Id = 4, Name = "AM" },
                new State() { Id = 5, Name = "BA" },
                new State() { Id = 6, Name = "CE" },
                new State() { Id = 7, Name = "DF" },
                new State() { Id = 8, Name = "ES" },
                new State() { Id = 9, Name = "GO" },
                new State() { Id = 10, Name = "MA" },
                new State() { Id = 11, Name = "MT" },
                new State() { Id = 12, Name = "MS" },
                new State() { Id = 13, Name = "MG" },
                new State() { Id = 14, Name = "PA" },
                new State() { Id = 15, Name = "PB" },
                new State() { Id = 16, Name = "PR" },
                new State() { Id = 17, Name = "PE" },
                new State() { Id = 18, Name = "PI" },
                new State() { Id = 19, Name = "RJ" },
                new State() { Id = 20, Name = "RN" },
                new State() { Id = 21, Name = "RS" },
                new State() { Id = 22, Name = "RO" },
                new State() { Id = 23, Name = "RR" },
                new State() { Id = 24, Name = "SC" },
                new State() { Id = 25, Name = "SP" },
                new State() { Id = 26, Name = "SE" },
                new State() { Id = 27, Name = "TO" }
            };
        builder.Entity<State>().HasData(listState);
        #endregion

        #region seed City
        List<City> listCity = new List<City>(){
            new City() {
                Id = 1,
                Name = "Barra Bonita",
                StateId = 25
            }
        };
        builder.Entity<City>().HasData(listCity);
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
                Image = "https://conteudo.solutudo.com.br/wp-content/uploads/2019/10/rock-nacional.jpg",
                ContactEmail = "gallo@email.com",
                MoreInfo = "",
                District = "Nova Barra",
                PublicSpace = "Nem lembro o que é",
                Cep = "1234567891234",
                CategoryId = 4,
                EventOwnerId = 1,
                StatusEventId = 2,
                CityId = 1,
                StateId = 25
            },
            new Event()
            {
                Id = 2,
                Name = "Competição de tapa na cara",
                ContactPhone = "14991144192",
                Price = 50.00m,
                EventDateBegin = DateTime.Parse("23/02/2023 12:00"),
                EventDateEnd = DateTime.Parse("10/03/2024 18:00"),
                Description = "Competição de tapa na cara! O vencedor ganha um prêmio especial.",
                Image = "https://video-images.vice.com/articles/5c939d5d2709700007238d39/lede/1553178006531-54222299_2219532254976982_7557531415907139584_o.jpeg",
                ContactEmail = "Kai@email.com",
                MoreInfo = "",
                District = "Nova Barra",
                PublicSpace = "Nem lembro o que é",
                Cep = "1234567891234",
                CategoryId = 6,
                EventOwnerId = 2,
                StatusEventId = 2,
                CityId = 1,
                StateId = 25
            },
            new Event()
            {
                Id = 3,
                Name = "Campeonato de Basquete",
                ContactPhone = "14991548292",
                Price = 50.00m,
                EventDateBegin = DateTime.Parse("10/01/2023 12:00"),
                EventDateEnd = DateTime.Parse("10/01/2023 18:00"),
                Description = "Campeonato mundial de basquete! Seirin vs Touou.",
                Image = "https://www.montealtoagora.com.br/upload/not-20220427185909basquete-22.jpg",
                ContactEmail = "Leo@email.com",
                MoreInfo = "",
                District = "Nova Barra",
                PublicSpace = "Nem lembro o que é",
                Cep = "1234567891234",
                CategoryId = 3,
                EventOwnerId = 3,
                StatusEventId = 3,
                CityId = 1,
                StateId = 25
            }
        };
        builder.Entity<Event>().HasData(listEvent);

        #endregion
    }
}
