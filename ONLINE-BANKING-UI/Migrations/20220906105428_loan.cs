using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLINE_BANKING_UI.Migrations
{
    public partial class loan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 40, nullable: true),
                    email = table.Column<string>(maxLength: 40, nullable: true),
                    number = table.Column<string>(maxLength: 40, nullable: true),
                    amount = table.Column<int>(nullable: false),
                    pincode = table.Column<string>(maxLength: 40, nullable: true),
                    city = table.Column<string>(maxLength: 40, nullable: true),
                    Adharnumber = table.Column<string>(maxLength: 40, nullable: true),
                    Pennumber = table.Column<string>(maxLength: 40, nullable: true),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan");
        }
    }
}
