using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class Transferamount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Transferamount");

            migrationBuilder.AddColumn<string>(
                name: "AccountHolderName",
                table: "Transferamount",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountHolderName",
                table: "Transferamount");

            migrationBuilder.AddColumn<int>(
                name: "AccountNumber",
                table: "Transferamount",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
