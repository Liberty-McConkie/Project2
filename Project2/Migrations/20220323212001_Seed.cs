using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tourists",
                columns: new[] { "TouristId", "AppointmentStart", "EmailAddress", "GroupName", "PhoneNumber", "SizeOfGroup" },
                values: new object[] { 1, "2022-03-23T10:00:00", "test@test.com", "Awesome", "555-555-1234", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "TouristId",
                keyValue: 1);
        }
    }
}
