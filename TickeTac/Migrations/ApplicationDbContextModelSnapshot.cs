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
                            Id = "7e18ae49-ed93-4d10-8c3b-04718052f21d",
                            ConcurrencyStamp = "9304fd70-94a6-4563-aacf-d36b8c6e122a",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "ff3a35e4-01c0-4fb0-a7ae-9f83a592aff6",
                            ConcurrencyStamp = "e8ac69a2-76e8-406b-b941-60e3008261da",
                            Name = "Usuario",
                            NormalizedName = "USUÁRIO"
                        },
                        new
                        {
                            Id = "2747e6fd-ba95-40b3-bbb7-7ffe666c1ed4",
                            ConcurrencyStamp = "130f7665-ee7f-4190-8526-5a7b81ec4438",
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
                            UserId = "88f17fb3-53f4-40e1-99f2-3e463809767e",
                            RoleId = "7e18ae49-ed93-4d10-8c3b-04718052f21d"
                        },
                        new
                        {
                            UserId = "405efe08-0a26-4297-ab11-40c5ee4173fc",
                            RoleId = "ff3a35e4-01c0-4fb0-a7ae-9f83a592aff6"
                        },
                        new
                        {
                            UserId = "5230e13d-5027-4f7b-8054-9fa13dd41a4b",
                            RoleId = "ff3a35e4-01c0-4fb0-a7ae-9f83a592aff6"
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

            modelBuilder.Entity("TickeTac.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

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

                    b.Property<string>("ProfilePicture")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

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

                    b.HasData(
                        new
                        {
                            Id = "88f17fb3-53f4-40e1-99f2-3e463809767e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "156411e8-7a66-4958-9c7a-0c9f5ed4448b",
                            Email = "Admin@TickeTac.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Leonardo",
                            NormalizedEmail = "ADMIN@TICKETAC.COM",
                            NormalizedUserName = "ADMIN@TICKETAC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA/6MtZhtp8v3VvDTMu5Oe4RWTZ14O4FH5dxtsYULWly+hO1fikBb8zV+4bJZ67Ahw==",
                            PhoneNumberConfirmed = false,
                            ProfilePicture = "",
                            SecurityStamp = "54232412",
                            TwoFactorEnabled = false,
                            UserName = "Admin@TickeTac.com"
                        },
                        new
                        {
                            Id = "405efe08-0a26-4297-ab11-40c5ee4173fc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5358deca-1108-4b58-9ca3-8856fdbd9044",
                            Email = "Kaique@TickeTac.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Kaique",
                            NormalizedEmail = "KAIQUE@TICKETAC.COM",
                            NormalizedUserName = "KAKA@TICKETAC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPI3u2mZwSZLOx6zZ8esbJrEC/KcSY9W9+WWvVXZ1fRe9bcglTlAxt1CWbMw/ShgfA==",
                            PhoneNumberConfirmed = false,
                            ProfilePicture = "",
                            SecurityStamp = "54232412",
                            TwoFactorEnabled = false,
                            UserName = "Kaka@TickeTac.com"
                        },
                        new
                        {
                            Id = "5230e13d-5027-4f7b-8054-9fa13dd41a4b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "026c9a2a-79ef-4395-bb8d-b5be3b9b9dae",
                            Email = "Carlos@Email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "carlos",
                            NormalizedEmail = "CARLOS@EMAIL.COM",
                            NormalizedUserName = "CARLOS@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI95zXlSrYcJTMIHdwgaBBcRtP9U5mGUXPlcGMJFcBRODZsMixFHrzZLXHiKCwZIQQ==",
                            PhoneNumberConfirmed = false,
                            ProfilePicture = "",
                            SecurityStamp = "54232412",
                            TwoFactorEnabled = false,
                            UserName = "Carlos@Email.com"
                        });
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

            modelBuilder.Entity("TickeTac.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Barra Bonita",
                            StateId = 25
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

                    b.Property<int>("CityId")
                        .HasMaxLength(70)
                        .HasColumnType("int");

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

                    b.Property<ushort>("EventOwnerId")
                        .HasColumnType("smallint unsigned");

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

                    b.Property<ushort>("StatusEventId")
                        .HasColumnType("smallint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("EventOwnerId");

                    b.HasIndex("StatusEventId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            CategoryId = (ushort)4,
                            Cep = "1234567891234",
                            CityId = 1,
                            ContactEmail = "gallo@email.com",
                            ContactPhone = "14991115478",
                            Description = "Evento de rock que será realizado em Barra Bonita, com grandes artistas musicais como Gallo e Edriano",
                            District = "Nova Barra",
                            EventDateBegin = new DateTime(2023, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDateEnd = new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            EventOwnerId = (ushort)1,
                            Image = "https://conteudo.solutudo.com.br/wp-content/uploads/2019/10/rock-nacional.jpg",
                            MoreInfo = "",
                            Name = "Show de Rock do Gallo",
                            Price = 150.99m,
                            PublicSpace = "Nem lembro o que é",
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EventOwner");

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            CpfCnpj = "00100200304",
                            Name = "José Gallo",
                            UserId = "405efe08-0a26-4297-ab11-40c5ee4173fc"
                        },
                        new
                        {
                            Id = (ushort)2,
                            CpfCnpj = "09876543211",
                            Name = "Carlos Eduardo",
                            UserId = "5230e13d-5027-4f7b-8054-9fa13dd41a4b"
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

            modelBuilder.Entity("TickeTac.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "AC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "AL"
                        },
                        new
                        {
                            Id = 3,
                            Name = "AP"
                        },
                        new
                        {
                            Id = 4,
                            Name = "AM"
                        },
                        new
                        {
                            Id = 5,
                            Name = "BA"
                        },
                        new
                        {
                            Id = 6,
                            Name = "CE"
                        },
                        new
                        {
                            Id = 7,
                            Name = "DF"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ES"
                        },
                        new
                        {
                            Id = 9,
                            Name = "GO"
                        },
                        new
                        {
                            Id = 10,
                            Name = "MA"
                        },
                        new
                        {
                            Id = 11,
                            Name = "MT"
                        },
                        new
                        {
                            Id = 12,
                            Name = "MS"
                        },
                        new
                        {
                            Id = 13,
                            Name = "MG"
                        },
                        new
                        {
                            Id = 14,
                            Name = "PA"
                        },
                        new
                        {
                            Id = 15,
                            Name = "PB"
                        },
                        new
                        {
                            Id = 16,
                            Name = "PR"
                        },
                        new
                        {
                            Id = 17,
                            Name = "PE"
                        },
                        new
                        {
                            Id = 18,
                            Name = "PI"
                        },
                        new
                        {
                            Id = 19,
                            Name = "RJ"
                        },
                        new
                        {
                            Id = 20,
                            Name = "RN"
                        },
                        new
                        {
                            Id = 21,
                            Name = "RS"
                        },
                        new
                        {
                            Id = 22,
                            Name = "RO"
                        },
                        new
                        {
                            Id = 23,
                            Name = "RR"
                        },
                        new
                        {
                            Id = 24,
                            Name = "SC"
                        },
                        new
                        {
                            Id = 25,
                            Name = "SP"
                        },
                        new
                        {
                            Id = 26,
                            Name = "SE"
                        },
                        new
                        {
                            Id = 27,
                            Name = "TO"
                        });
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
                    b.HasOne("TickeTac.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TickeTac.Models.AppUser", null)
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

                    b.HasOne("TickeTac.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TickeTac.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TickeTac.Models.City", b =>
                {
                    b.HasOne("TickeTac.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("TickeTac.Models.Event", b =>
                {
                    b.HasOne("TickeTac.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TickeTac.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TickeTac.Models.EventOwner", "EventOwner")
                        .WithMany()
                        .HasForeignKey("EventOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TickeTac.Models.StatusEvent", "StatusEvent")
                        .WithMany()
                        .HasForeignKey("StatusEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("EventOwner");

                    b.Navigation("StatusEvent");
                });

            modelBuilder.Entity("TickeTac.Models.EventOwner", b =>
                {
                    b.HasOne("TickeTac.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

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

            modelBuilder.Entity("TickeTac.Models.AppUser", b =>
                {
                    b.Navigation("UserMadeReview");
                });

            modelBuilder.Entity("TickeTac.Models.Event", b =>
                {
                    b.Navigation("ReviewReceived");
                });
#pragma warning restore 612, 618
        }
    }
}
