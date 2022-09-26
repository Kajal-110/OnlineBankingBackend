using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class CreatePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "CreatePassword",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CerdHolderName = table.Column<string>(maxLength: 30, nullable: true),
                    EnterPassword = table.Column<string>(maxLength: 30, nullable: true),
                    MemberSince = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatePassword", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatePassword");

            migrationBuilder.CreateTable(
                name: "CreatePassword",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterDebitCerdHolderName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Enterpin = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MemberSince = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatePassword", x => x.id);
                });
        }
    }
}
