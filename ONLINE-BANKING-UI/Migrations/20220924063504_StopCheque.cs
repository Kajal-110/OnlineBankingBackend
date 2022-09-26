using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class StopCheque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StopCheque",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountHolderName = table.Column<string>(maxLength: 30, nullable: true),
                    PartyName = table.Column<string>(maxLength: 30, nullable: true),
                    TypeOfBankAccount = table.Column<string>(maxLength: 30, nullable: true),
                    AccountNumber = table.Column<string>(maxLength: 30, nullable: true),
                    CheckNumber = table.Column<string>(maxLength: 30, nullable: true),
                    Amount = table.Column<string>(maxLength: 30, nullable: true),
                    CheckStopPaymentReason = table.Column<string>(maxLength: 50, nullable: true),
                    DateOnTheCheck = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopCheque", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StopCheque");
        }
    }
}
