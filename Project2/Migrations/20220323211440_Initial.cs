using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tourists",
                columns: table => new
                {
                    TouristId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    SizeOfGroup = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    AppointmentStart = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tourists", x => x.TouristId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tourists");
        }
    }
}
