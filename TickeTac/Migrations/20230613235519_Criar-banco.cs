using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TickeTac.Migrations
{
    public partial class Criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfilePicture = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<ushort>(type: "smallint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatusEvent",
                columns: table => new
                {
                    Id = table.Column<ushort>(type: "smallint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusEvent", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EventOwner",
                columns: table => new
                {
                    Id = table.Column<ushort>(type: "smallint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CpfCnpj = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOwner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventOwner_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<ushort>(type: "smallint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPhone = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EventDateBegin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EventDateEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MoreInfo = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityId = table.Column<int>(type: "int", maxLength: 70, nullable: false),
                    District = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublicSpace = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryId = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    StatusEventId = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    StateId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    EventOwnerId = table.Column<ushort>(type: "smallint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_EventOwner_EventOwnerId",
                        column: x => x.EventOwnerId,
                        principalTable: "EventOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_StatusEvent_StatusEventId",
                        column: x => x.StatusEventId,
                        principalTable: "StatusEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EventReviews",
                columns: table => new
                {
                    EventId = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ReviewText = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReviewDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventReviews", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EventReviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventReviews_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b18aab2b-7c57-4237-b8ea-9f5d795c5630", "c58c4568-6d34-4c65-bff7-b320c9691778", "Usuario", "USUÁRIO" },
                    { "c6a6cbe9-152a-4972-8d71-ff89c0e5fb4f", "2216853d-b05f-428f-9c41-d367af6ab7ae", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "497e1f18-b889-415d-a310-d1745195b439", 0, "f2950d1e-7280-476d-86ae-16c9f3dbef71", "Admin@TickeTac.com", true, false, null, "Admin", "ADMIN@TICKETAC.COM", "ADMIN@TICKETAC.COM", "AQAAAAEAACcQAAAAEEguJ2bYeM2dUjEDDROqC+bPQxNFABR3XVDoQnelWDzzM3H06/83pr0UEcmyvMuVtw==", null, false, "", "22841149", false, "Admin@TickeTac.com" },
                    { "6da9affb-c03f-419a-8486-73cf49fc51a9", 0, "09d41b39-c259-4fe3-b1e7-8bb42f1343b5", "Gallo@Email.com", true, false, null, "José Gallo", "GALLO@EMAIL.COM", "GALLO@EMAIL.COM", "AQAAAAEAACcQAAAAEEm7tVtOkeH1fIu8IYc2kijcCs8DnlhzarknF8wrmqCgOLXIgwxgA/tUgHmjVjK4FA==", null, false, "https://avatars.githubusercontent.com/u/12284966?v=4", "22841149", false, "Gallo@Email.com" },
                    { "8aa0e468-a061-4235-80e9-79689cc22c60", 0, "32e7920a-513b-40dc-ad00-7b38f02e26be", "Leo@Email.com", true, false, null, "Leonardo", "LEO@EMAIL.COM", "LEO@EMAIL.COM", "AQAAAAEAACcQAAAAELh7NxGkxRnpbHpl8nMDeljiAraLkkn3PPJAjjuh7SqxPiwmUT36fzV4XYzN6s0fTw==", null, false, "https://avatars.githubusercontent.com/u/99449193?v=4", "22841149", false, "Leo@Email.com" },
                    { "f7500208-c23c-4d31-add9-c8b2a4437376", 0, "2712c3fb-5f47-4601-99f8-4819b4ae02b5", "Kai@Email.com", true, false, null, "Kaique", "KAI@EMAIL.COM", "KAI@EMAIL.COM", "AQAAAAEAACcQAAAAEGTt/jeTJEz8dWrraljJaTjDdr1VNDyGSVU1lFqRai+O3con/Nm6H/Rs7DgfNWjieQ==", null, false, "https://avatars.githubusercontent.com/u/99449012?v=4", "22841149", false, "Kai@Email.com" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Img", "Name" },
                values: new object[,]
                {
                    { (ushort)1, "https://cdn-icons-png.flaticon.com/512/1756/1756784.png", "Feiras e exposições de Arte" },
                    { (ushort)2, "https://cdn-icons-png.flaticon.com/512/3399/3399161.png", "Leilões" },
                    { (ushort)3, "https://cdn-icons-png.flaticon.com/512/33/33736.png", "Esporte" },
                    { (ushort)4, "https://i.pinimg.com/originals/ca/16/fd/ca16fd3428cd473af9301ff50894f456.png", "Música" },
                    { (ushort)5, "https://cdn-icons-png.flaticon.com/512/1101/1101820.png", "Games" },
                    { (ushort)6, "https://cdn2.iconfinder.com/data/icons/theater-stage-performers/287/artist-show-performance-006-512.png", "Entretenimento" },
                    { (ushort)7, "https://static.thenounproject.com/png/34322-200.png", "Anime" },
                    { (ushort)8, "https://cdn-icons-png.flaticon.com/512/42/42972.png", "Formatura" }
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "AC" },
                    { 2, "AL" },
                    { 3, "AP" },
                    { 4, "AM" },
                    { 5, "BA" },
                    { 6, "CE" },
                    { 7, "DF" },
                    { 8, "ES" },
                    { 9, "GO" },
                    { 10, "MA" },
                    { 11, "MT" },
                    { 12, "MS" },
                    { 13, "MG" },
                    { 14, "PA" },
                    { 15, "PB" },
                    { 16, "PR" },
                    { 17, "PE" },
                    { 18, "PI" },
                    { 19, "RJ" },
                    { 20, "RN" },
                    { 21, "RS" },
                    { 22, "RO" },
                    { 23, "RR" },
                    { 24, "SC" },
                    { 25, "SP" },
                    { 26, "SE" },
                    { 27, "TO" }
                });

            migrationBuilder.InsertData(
                table: "StatusEvent",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (ushort)1, "Concluido" },
                    { (ushort)2, "Em andamento" },
                    { (ushort)3, "Confirmado" },
                    { (ushort)4, "Cancelado" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c6a6cbe9-152a-4972-8d71-ff89c0e5fb4f", "497e1f18-b889-415d-a310-d1745195b439" },
                    { "b18aab2b-7c57-4237-b8ea-9f5d795c5630", "6da9affb-c03f-419a-8486-73cf49fc51a9" },
                    { "b18aab2b-7c57-4237-b8ea-9f5d795c5630", "8aa0e468-a061-4235-80e9-79689cc22c60" },
                    { "b18aab2b-7c57-4237-b8ea-9f5d795c5630", "f7500208-c23c-4d31-add9-c8b2a4437376" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[] { 1, "Barra Bonita", 25 });

            migrationBuilder.InsertData(
                table: "EventOwner",
                columns: new[] { "Id", "CpfCnpj", "Name", "UserId" },
                values: new object[,]
                {
                    { (ushort)1, "00100200304", "José Gallo", "6da9affb-c03f-419a-8486-73cf49fc51a9" },
                    { (ushort)2, "09876543211", "Kaique", "f7500208-c23c-4d31-add9-c8b2a4437376" },
                    { (ushort)3, "24307069030", "Leonardo", "8aa0e468-a061-4235-80e9-79689cc22c60" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CategoryId", "Cep", "CityId", "ContactEmail", "ContactPhone", "Description", "District", "EventDateBegin", "EventDateEnd", "EventOwnerId", "Image", "MoreInfo", "Name", "Price", "PublicSpace", "StateId", "StatusEventId" },
                values: new object[] { (ushort)1, (ushort)4, "1234567891234", 1, "gallo@email.com", "14991115478", "Evento de rock que será realizado em Barra Bonita, com grandes artistas musicais como Gallo e Edriano", "Nova Barra", new DateTime(2023, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), (ushort)1, "https://conteudo.solutudo.com.br/wp-content/uploads/2019/10/rock-nacional.jpg", "", "Show de Rock do Gallo", 150.99m, "Nem lembro o que é", 25, (ushort)2 });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CategoryId", "Cep", "CityId", "ContactEmail", "ContactPhone", "Description", "District", "EventDateBegin", "EventDateEnd", "EventOwnerId", "Image", "MoreInfo", "Name", "Price", "PublicSpace", "StateId", "StatusEventId" },
                values: new object[] { (ushort)2, (ushort)6, "1234567891234", 1, "Kai@email.com", "14991144192", "Competição de tapa na cara! O vencedor ganha um prêmio especial.", "Nova Barra", new DateTime(2023, 2, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), (ushort)2, "https://video-images.vice.com/articles/5c939d5d2709700007238d39/lede/1553178006531-54222299_2219532254976982_7557531415907139584_o.jpeg", "", "Competição de tapa na cara", 50.00m, "Nem lembro o que é", 25, (ushort)2 });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CategoryId", "Cep", "CityId", "ContactEmail", "ContactPhone", "Description", "District", "EventDateBegin", "EventDateEnd", "EventOwnerId", "Image", "MoreInfo", "Name", "Price", "PublicSpace", "StateId", "StatusEventId" },
                values: new object[] { (ushort)3, (ushort)3, "1234567891234", 1, "Leo@email.com", "14991548292", "Campeonato mundial de basquete! Seirin vs Touou.", "Nova Barra", new DateTime(2023, 1, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), (ushort)3, "https://www.montealtoagora.com.br/upload/not-20220427185909basquete-22.jpg", "", "Campeonato de Basquete", 50.00m, "Nem lembro o que é", 25, (ushort)3 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CategoryId",
                table: "Event",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CityId",
                table: "Event",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventOwnerId",
                table: "Event",
                column: "EventOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_StateId",
                table: "Event",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_StatusEventId",
                table: "Event",
                column: "StatusEventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventOwner_UserId",
                table: "EventOwner",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventReviews_UserId",
                table: "EventReviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EventReviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "EventOwner");

            migrationBuilder.DropTable(
                name: "StatusEvent");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
