using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TickeTac.Migrations
{
    public partial class CriarBanco : Migration
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
                    Image = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true)
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
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    { "3cab5ecd-72c6-4d69-b1d3-2749e36ce64e", "f5644878-56e2-4fe0-a1af-2413762c1ae6", "Administrador", "ADMINISTRADOR" },
                    { "bc88ee45-7fc5-43b6-ba51-cb2d2c9fc3e2", "2e785ebb-bb65-4ba3-bb30-148bb7ed9f13", "Usuario", "USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3670aee8-6c78-4a7e-a794-40275d8b1070", 0, "504bd98b-2122-4482-9fa8-422ea916651d", "Kai@Email.com", true, false, null, "Kaique", "KAI@EMAIL.COM", "KAI@EMAIL.COM", "AQAAAAEAACcQAAAAEDNLrBQl+kIgxgwlgLy/ISfSd3TLnEIVpBFCOk3ekTg4Y7F+GVFEI4zlPrIA8IuxbA==", null, false, "https://avatars.githubusercontent.com/u/99449012?v=4", "50931783", false, "Kai@Email.com" },
                    { "435fa518-a463-4f25-ae9d-653cedc990ce", 0, "cc0e0330-b789-4620-8745-600eb88e6e8e", "Admin@TickeTac.com", true, false, null, "Admin", "ADMIN@TICKETAC.COM", "ADMIN@TICKETAC.COM", "AQAAAAEAACcQAAAAEPXaxY8yq843opljaGQlBjUbec6LjLKl//39FRu68MjW3vwFUo4VU4/Sm1Xa0m9bhg==", null, false, "", "50931783", false, "Admin@TickeTac.com" },
                    { "d05ed18e-2352-4b40-970e-d2b54834e23d", 0, "a391ca59-64a3-4bb8-9069-ff91748c0598", "Gallo@Email.com", true, false, null, "José Gallo", "GALLO@EMAIL.COM", "GALLO@EMAIL.COM", "AQAAAAEAACcQAAAAEG5pVrGQcV2WAyg6RCP5uCEoHunLXb9CM3ISHkRkLlvrjFEbgX/Bhltu65xjI0dpSg==", null, false, "https://avatars.githubusercontent.com/u/12284966?v=4", "50931783", false, "Gallo@Email.com" },
                    { "d346f07b-302f-4e8c-877c-d5cff3c35fcc", 0, "4bc0c2e2-358e-42db-b4a9-1e5a2d9aefe7", "Leo@Email.com", true, false, null, "Leonardo", "LEO@EMAIL.COM", "LEO@EMAIL.COM", "AQAAAAEAACcQAAAAEHib5xMxRgVroE8L+HEScEm4mFHBth/seibG/uiUHMveMvwzSmn8cs8YwQZxICfIlw==", null, false, "https://avatars.githubusercontent.com/u/99449193?v=4", "50931783", false, "Leo@Email.com" }
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
                    { "bc88ee45-7fc5-43b6-ba51-cb2d2c9fc3e2", "3670aee8-6c78-4a7e-a794-40275d8b1070" },
                    { "3cab5ecd-72c6-4d69-b1d3-2749e36ce64e", "435fa518-a463-4f25-ae9d-653cedc990ce" },
                    { "bc88ee45-7fc5-43b6-ba51-cb2d2c9fc3e2", "d05ed18e-2352-4b40-970e-d2b54834e23d" },
                    { "bc88ee45-7fc5-43b6-ba51-cb2d2c9fc3e2", "d346f07b-302f-4e8c-877c-d5cff3c35fcc" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[] { 1, "Barra Bonita", 25 });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CategoryId", "Cep", "CityId", "ContactEmail", "ContactPhone", "Description", "District", "EventDateBegin", "EventDateEnd", "Image", "MoreInfo", "Name", "Price", "PublicSpace", "StateId", "StatusEventId", "UserId" },
                values: new object[] { (ushort)1, (ushort)4, "1234567891234", 1, "gallo@email.com", "14991115478", "Evento de rock que será realizado em Barra Bonita, com grandes artistas musicais como Gallo e Edriano", "Nova Barra", new DateTime(2023, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://conteudo.solutudo.com.br/wp-content/uploads/2019/10/rock-nacional.jpg", "", "Show de Rock do Gallo", 150.99m, "Nem lembro o que é", 25, (ushort)2, "d05ed18e-2352-4b40-970e-d2b54834e23d" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CategoryId", "Cep", "CityId", "ContactEmail", "ContactPhone", "Description", "District", "EventDateBegin", "EventDateEnd", "Image", "MoreInfo", "Name", "Price", "PublicSpace", "StateId", "StatusEventId", "UserId" },
                values: new object[] { (ushort)2, (ushort)6, "1234567891234", 1, "Kai@email.com", "14991144192", "Competição de tapa na cara! O vencedor ganha um prêmio especial.", "Nova Barra", new DateTime(2023, 2, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://video-images.vice.com/articles/5c939d5d2709700007238d39/lede/1553178006531-54222299_2219532254976982_7557531415907139584_o.jpeg", "", "Competição de tapa na cara", 50.00m, "Nem lembro o que é", 25, (ushort)2, "3670aee8-6c78-4a7e-a794-40275d8b1070" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CategoryId", "Cep", "CityId", "ContactEmail", "ContactPhone", "Description", "District", "EventDateBegin", "EventDateEnd", "Image", "MoreInfo", "Name", "Price", "PublicSpace", "StateId", "StatusEventId", "UserId" },
                values: new object[] { (ushort)3, (ushort)3, "1234567891234", 1, "Leo@email.com", "14991548292", "Campeonato mundial de basquete! Seirin vs Touou.", "Nova Barra", new DateTime(2023, 1, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://www.montealtoagora.com.br/upload/not-20220427185909basquete-22.jpg", "", "Campeonato de Basquete", 50.00m, "Nem lembro o que é", 25, (ushort)3, "d346f07b-302f-4e8c-877c-d5cff3c35fcc" });

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
                name: "IX_Event_StateId",
                table: "Event",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_StatusEventId",
                table: "Event",
                column: "StatusEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "StatusEvent");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
