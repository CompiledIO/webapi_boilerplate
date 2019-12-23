using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Infrastructure.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Portal");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Portal",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Portal",
                table: "Users",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Email", "FirstName", "LastName", "Password", "Token", "Username" },
                values: new object[] { new Guid("e4b25385-ea86-4d77-acb5-a6b55d097985"), new DateTime(2019, 12, 23, 13, 9, 16, 199, DateTimeKind.Local).AddTicks(5971), new DateTime(2019, 12, 23, 13, 9, 16, 200, DateTimeKind.Local).AddTicks(5369), "test@test.com", "Administrator", "Developer", "password", null, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "Portal");
        }
    }
}
