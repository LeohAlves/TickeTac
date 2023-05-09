﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TickeTac.Data;

#nullable disable

namespace TickeTac.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9d5356f2-5847-459b-8901-dabeb5419d34",
                            ConcurrencyStamp = "44a4f50b-10ac-4982-b95a-f86cf31f540f",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "91fe25cd-5a34-4ed7-9710-0d41615ed33f",
                            ConcurrencyStamp = "68ff9b06-6234-41c1-a48d-400710b009a8",
                            Name = "Usuario",
                            NormalizedName = "USUÁRIO"
                        },
                        new
                        {
                            Id = "37e86ad5-93ea-4ae1-a3ce-9948b6fb5953",
                            ConcurrencyStamp = "fb3cd118-0102-4733-aa72-550c3ffc042c",
                            Name = "Organizador",
                            NormalizedName = "ORGANIZADOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "80afedbc-2d14-4366-9a75-d707740253fe",
                            RoleId = "9d5356f2-5847-459b-8901-dabeb5419d34"
                        },
                        new
                        {
                            UserId = "b589e0e9-8e8e-4e27-9752-fbd393720e65",
                            RoleId = "91fe25cd-5a34-4ed7-9710-0d41615ed33f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TickeTac.Models.Category", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned");

                    b.Property<string>("Img")
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            Img = "https://cdn-icons-png.flaticon.com/512/1756/1756784.png",
                            Name = "Feiras e exposições Arte"
                        },
                        new
                        {
                            Id = (ushort)2,
                            Img = "https://cdn-icons-png.flaticon.com/512/3399/3399161.png",
                            Name = "Leilões "
                        },
                        new
                        {
                            Id = (ushort)3,
                            Img = "https://cdn-icons-png.flaticon.com/512/33/33736.png",
                            Name = "Esporte"
                        },
                        new
                        {
                            Id = (ushort)4,
                            Img = "https://i.pinimg.com/originals/ca/16/fd/ca16fd3428cd473af9301ff50894f456.png",
                            Name = "Musica"
                        },
                        new
                        {
                            Id = (ushort)5,
                            Img = "https://cdn-icons-png.flaticon.com/512/1101/1101820.png",
                            Name = "Games"
                        },
                        new
                        {
                            Id = (ushort)6,
                            Img = "https://cdn2.iconfinder.com/data/icons/theater-stage-performers/287/artist-show-performance-006-512.png",
                            Name = "Stand 'Up"
                        },
                        new
                        {
                            Id = (ushort)7,
                            Img = "https://static.thenounproject.com/png/34322-200.png",
                            Name = "Anime"
                        },
                        new
                        {
                            Id = (ushort)8,
                            Img = "https://cdn-icons-png.flaticon.com/512/42/42972.png",
                            Name = "Formatura"
                        });
                });

            modelBuilder.Entity("TickeTac.Models.Event", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned");

                    b.Property<ushort>("CategoryId")
                        .HasColumnType("smallint unsigned");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("EventDateBegin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EventDateEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("MoreInfo")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("PublicSpace")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<ushort>("StatusEventId")
                        .HasColumnType("smallint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StatusEventId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            CategoryId = (ushort)4,
                            Cep = "1234567891234",
                            City = "Barra Bonita",
                            ContactEmail = "gallo@email.com",
                            ContactPhone = "14991115478",
                            Description = "Evento de rock que será realizado em Barra Bonita, com grandes artistas musicais como Gallo e Edriano",
                            District = "Nova Barra",
                            EventDateBegin = new DateTime(2023, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDateEnd = new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "",
                            MoreInfo = "",
                            Name = "Show de Rock do Gallo",
                            Price = 150.99m,
                            PublicSpace = "Nem lembro o que é",
                            State = "São Paulo",
                            StatusEventId = (ushort)2
                        });
                });

            modelBuilder.Entity("TickeTac.Models.EventOwner", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<ushort>("EventId")
                        .HasColumnType("smallint unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("EventManager");

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            CpfCnpj = "00100200304",
                            EventId = (ushort)1,
                            Name = "José Gallo",
                            UserId = "b589e0e9-8e8e-4e27-9752-fbd393720e65"
                        });
                });

            modelBuilder.Entity("TickeTac.Models.EventReview", b =>
                {
                    b.Property<ushort>("EventId")
                        .HasColumnType("smallint unsigned")
                        .HasColumnOrder(1);

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)")
                        .HasColumnOrder(2);

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReviewText")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.HasKey("EventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("EventReviews");
                });

            modelBuilder.Entity("TickeTac.Models.StatusEvent", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("StatusEvent");

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            Name = "Concluido"
                        },
                        new
                        {
                            Id = (ushort)2,
                            Name = "Em andamento"
                        },
                        new
                        {
                            Id = (ushort)3,
                            Name = "Confirmado"
                        },
                        new
                        {
                            Id = (ushort)4,
                            Name = "Cancelado"
                        });
                });

            modelBuilder.Entity("TickeTac.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ProfilePicture")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "80afedbc-2d14-4366-9a75-d707740253fe",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aff969fa-ffb1-4519-8009-aa5729fc417e",
                            Email = "Admin@TickeTac.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TICKETAC.COM",
                            NormalizedUserName = "ADMIN@TICKETAC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJx18o/+AUWantv4z6QGzEqOChiDiqcWSTjfb0+/vu9tFRcqKH8vcXpjurFjzC8SLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "61724767",
                            TwoFactorEnabled = false,
                            UserName = "Admin@TickeTac.com",
                            Name = "Leonardo",
                            ProfilePicture = ""
                        },
                        new
                        {
                            Id = "b589e0e9-8e8e-4e27-9752-fbd393720e65",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "98e673ed-c785-4c48-909b-d0b1b592effe",
                            Email = "Kaique@TickeTac.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "KAIQUE@TICKETAC.COM",
                            NormalizedUserName = "KAKA@TICKETAC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL6AGMYmrsXIxv8K0YnhRvEFpsduef6w8lqpRtu2cVM6mS9JsZdLSQU9Tcbr2MvHTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "61724767",
                            TwoFactorEnabled = false,
                            UserName = "Kaka@TickeTac.com",
                            Name = "Kaique",
                            ProfilePicture = ""
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TickeTac.Models.Event", b =>
                {
                    b.HasOne("TickeTac.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TickeTac.Models.StatusEvent", "StatusEvent")
                        .WithMany()
                        .HasForeignKey("StatusEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("StatusEvent");
                });

            modelBuilder.Entity("TickeTac.Models.EventOwner", b =>
                {
                    b.HasOne("TickeTac.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TickeTac.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TickeTac.Models.EventReview", b =>
                {
                    b.HasOne("TickeTac.Models.Event", "Event")
                        .WithMany("ReviewReceived")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TickeTac.Models.AppUser", "User")
                        .WithMany("UserMadeReview")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TickeTac.Models.Event", b =>
                {
                    b.Navigation("ReviewReceived");
                });

            modelBuilder.Entity("TickeTac.Models.AppUser", b =>
                {
                    b.Navigation("UserMadeReview");
                });
#pragma warning restore 612, 618
        }
    }
}
