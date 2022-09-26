using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class Deposite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Accounts");

            migrationBuilder.CreateTable(
                name: "Depositeamount",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    MemberSince = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositeamount", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depositeamount");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
