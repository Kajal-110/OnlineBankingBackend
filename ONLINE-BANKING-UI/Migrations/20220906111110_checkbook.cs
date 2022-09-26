using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class checkbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountType = table.Column<string>(maxLength: 30, nullable: true),
                    Branch = table.Column<string>(maxLength: 30, nullable: true),
                    TheresholdLimit = table.Column<string>(maxLength: 30, nullable: true),
                    Checkbooks = table.Column<string>(maxLength: 9, nullable: true),
                    CheckLeaves = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckBook", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckBook");
        }
    }
}
