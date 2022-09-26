using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pennumber",
                table: "Loan");

            migrationBuilder.AlterColumn<string>(
                name: "Adharnumber",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pannumber",
                table: "Loan",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "CreateAccount",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Transferamount",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<int>(nullable: false),
                    Totalamount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferamount", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transferamount");

            migrationBuilder.DropColumn(
                name: "Pannumber",
                table: "Loan");

            migrationBuilder.AlterColumn<string>(
                name: "Adharnumber",
                table: "Loan",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pennumber",
                table: "Loan",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amount",
                table: "CreateAccount",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
