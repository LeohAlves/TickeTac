using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TickeTac.Migrations
{
    public partial class seedAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d676db68-b442-4efd-b914-e8b8634324bc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9f6c292-4faf-4efd-8719-72b93f976d4c", "c6fe96c1-ee0e-4e76-8d66-ca44c7b14c46" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9f6c292-4faf-4efd-8719-72b93f976d4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6fe96c1-ee0e-4e76-8d66-ca44c7b14c46");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ac86a00-c655-4576-9471-4011f7ccf994", "5bbb4f48-80c2-4796-9efa-af2eaf4162ee", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4f68396-5b05-47f8-96b5-50cc37e1854a", "2a552dbf-405a-4cc3-a75a-fd02a36dde6e", "Usuario", "USUÁRIO" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b7cdc25b-f30d-44b7-afef-729742794371", 0, "b7c2f5f9-f845-4b33-a1db-fed2da6efa6b", "AppUser", "Leonardo@TickeTac.com", true, false, null, "Leonardo", "LEONARDO@TICKETAC.COM", "LEO@TICKETAC.COM", "AQAAAAEAACcQAAAAEIgDNiKYZRgy987mfaxX6bzh6lphHyZYvdyvZma7OF6mCstnpHbVQ6lSy/ACe8sxHw==", null, false, "", "42842654", false, "Leo@TickeTac.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4ac86a00-c655-4576-9471-4011f7ccf994", "b7cdc25b-f30d-44b7-afef-729742794371" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4f68396-5b05-47f8-96b5-50cc37e1854a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ac86a00-c655-4576-9471-4011f7ccf994", "b7cdc25b-f30d-44b7-afef-729742794371" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac86a00-c655-4576-9471-4011f7ccf994");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7cdc25b-f30d-44b7-afef-729742794371");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9f6c292-4faf-4efd-8719-72b93f976d4c", "d9d97e15-e58c-4b74-8c3f-85e9b0a73c87", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d676db68-b442-4efd-b914-e8b8634324bc", "b419ef34-86d0-4cf3-ba9f-ff392f865e0d", "Usuario", "USUÁRIO" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6fe96c1-ee0e-4e76-8d66-ca44c7b14c46", 0, "29f68177-3663-4862-a7d1-747ca2dc799e", "AppUser", "Leonardo@TickeTac.com", true, false, null, "Leonardo", "LEONARDO@TICKETAC.COM", "LEO@TICKETAC.COM", "AQAAAAEAACcQAAAAEH0X7mlC4cN9CJkfvflAWYdkZMYaZ8fvkV1qEo/bsMrX9Mil9h9ACTStdgExHbx5aQ==", null, false, "", "60720217", false, "Leo@TickeTac.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c9f6c292-4faf-4efd-8719-72b93f976d4c", "c6fe96c1-ee0e-4e76-8d66-ca44c7b14c46" });
        }
    }
}
