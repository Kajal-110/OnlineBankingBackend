using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class DebitCardV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "DebitCard",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CardNumber",
                table: "DebitCard",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
