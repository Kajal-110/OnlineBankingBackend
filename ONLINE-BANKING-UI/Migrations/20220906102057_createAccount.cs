using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class createAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MemberSince",
                table: "Register",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CreateAccount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    Password = table.Column<string>(maxLength: 10, nullable: true),
                    Address = table.Column<string>(maxLength: 30, nullable: true),
                    Dateofbirth = table.Column<string>(maxLength: 10, nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(maxLength: 8, nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateAccount", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateAccount");

            migrationBuilder.DropColumn(
                name: "MemberSince",
                table: "Register");
        }
    }
}
