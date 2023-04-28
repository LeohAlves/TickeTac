using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TickeTac.Migrations
{
    public partial class EventOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fb96902-0147-4ab3-a6e8-2f02ddc85d01");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b4860ee-26a6-4716-bfd4-c1c2b37da9eb", "4187b97e-b8f9-43ff-927c-2180601cda18" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b4860ee-26a6-4716-bfd4-c1c2b37da9eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4187b97e-b8f9-43ff-927c-2180601cda18");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e662c287-120f-4732-85a6-13dde26e268d", "0935c953-c4e8-4250-921c-95b0a27dc5a8", "Administrador", "ADMINISTRADOR" },
                    { "e9021b4d-05b1-4b4f-857f-db6d9cfce3db", "19eb9e8b-11e6-4697-bbac-34ac2a396d2b", "Usuario", "USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "56435dff-d5ad-45a1-8243-b0c3655098c0", 0, "bd8d31c9-4561-4dc6-8a45-af5635c2013f", "AppUser", "Kaique@TickeTac.com", true, false, null, "Kaique", "KAIQUE@TICKETAC.COM", "KAKA@TICKETAC.COM", "AQAAAAEAACcQAAAAEHmHarBI7DnwJ7GGyX3rjcXxOYSa/DcLmL+INKV4E0t2kSxH+5W+/YT7263DJmOEjw==", null, false, "", "33650236", false, "Kaka@TickeTac.com" },
                    { "764a3c42-e4fa-42a7-a2b3-fb892577abfc", 0, "e63c42bb-e58e-460e-999b-5df543b106e1", "AppUser", "Leonardo@TickeTac.com", true, false, null, "Leonardo", "LEONARDO@TICKETAC.COM", "LEO@TICKETAC.COM", "AQAAAAEAACcQAAAAECyNqpkkg4NGU+CclsXLup3dqqAtxaSSKodPpnA/gmKxR5tGYxrzLs8bYoYg1irNFQ==", null, false, "", "33650236", false, "Leo@TickeTac.com" }
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
                values: new object[] { "e9021b4d-05b1-4b4f-857f-db6d9cfce3db", "56435dff-d5ad-45a1-8243-b0c3655098c0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e662c287-120f-4732-85a6-13dde26e268d", "764a3c42-e4fa-42a7-a2b3-fb892577abfc" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CategoryId", "Cep", "City", "ContactEmail", "ContactPhone", "Description", "District", "EventDateBegin", "EventDateEnd", "Image", "MoreInfo", "Name", "Price", "PublicSpace", "State", "StatusEventId" },
                values: new object[] { (ushort)1, (ushort)4, "1234567891234", "Barra Bonita", "gallo@email.com", "14991115478", "Evento de rock que será realizado em Barra Bonita, com grandes artistas musicais como Gallo e Edriano", "Nova Barra", new DateTime(2023, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "", "", "Show de Rock do Gallo", 150m, "Nem lembro o que é", "São Paulo", (ushort)2 });

            migrationBuilder.InsertData(
                table: "EventManager",
                columns: new[] { "Id", "CpfCnpj", "EventId", "Name", "UserId" },
                values: new object[] { (ushort)1, "00100200304", (ushort)1, "José Gallo", "56435dff-d5ad-45a1-8243-b0c3655098c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9021b4d-05b1-4b4f-857f-db6d9cfce3db", "56435dff-d5ad-45a1-8243-b0c3655098c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e662c287-120f-4732-85a6-13dde26e268d", "764a3c42-e4fa-42a7-a2b3-fb892577abfc" });

            migrationBuilder.DeleteData(
                table: "EventManager",
                keyColumn: "Id",
                keyValue: (ushort)1);

            migrationBuilder.DeleteData(
                table: "StatusEvent",
                keyColumn: "Id",
                keyValue: (ushort)1);

            migrationBuilder.DeleteData(
                table: "StatusEvent",
                keyColumn: "Id",
                keyValue: (ushort)3);

            migrationBuilder.DeleteData(
                table: "StatusEvent",
                keyColumn: "Id",
                keyValue: (ushort)4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e662c287-120f-4732-85a6-13dde26e268d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9021b4d-05b1-4b4f-857f-db6d9cfce3db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56435dff-d5ad-45a1-8243-b0c3655098c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "764a3c42-e4fa-42a7-a2b3-fb892577abfc");

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: (ushort)1);

            migrationBuilder.DeleteData(
                table: "StatusEvent",
                keyColumn: "Id",
                keyValue: (ushort)2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b4860ee-26a6-4716-bfd4-c1c2b37da9eb", "c82e973e-7c96-4d3d-809a-9889beb834ed", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fb96902-0147-4ab3-a6e8-2f02ddc85d01", "c28906da-46f5-4781-bbde-f20b4b68e36a", "Usuario", "USUÁRIO" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4187b97e-b8f9-43ff-927c-2180601cda18", 0, "eb9fc0ad-0637-4d63-839d-fb61ef30d8e3", "AppUser", "Leonardo@TickeTac.com", true, false, null, "Leonardo", "LEONARDO@TICKETAC.COM", "LEO@TICKETAC.COM", "AQAAAAEAACcQAAAAEJrEk2yPLocenWol72kynvyetWV4OTQjXJyUGDgJbYST8JagCM7AsJizPIBOUCZIIA==", null, false, "", "22613965", false, "Leo@TickeTac.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b4860ee-26a6-4716-bfd4-c1c2b37da9eb", "4187b97e-b8f9-43ff-927c-2180601cda18" });
        }
    }
}
