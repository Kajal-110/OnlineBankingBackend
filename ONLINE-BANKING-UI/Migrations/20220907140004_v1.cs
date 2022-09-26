using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Depositeamount",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Depositeamount_AccountId",
                table: "Depositeamount",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Depositeamount_Accounts_AccountId",
                table: "Depositeamount",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depositeamount_Accounts_AccountId",
                table: "Depositeamount");

            migrationBuilder.DropIndex(
                name: "IX_Depositeamount_AccountId",
                table: "Depositeamount");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Depositeamount");
        }
    }
}
