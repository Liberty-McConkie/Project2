using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSlot = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "Tourists",
                columns: table => new
                {
                    TouristId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    SizeOfGroup = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tourists", x => x.TouristId);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 1, "8:00 a.m. - 9:00 a.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 2, "9:00 a.m. - 10:00 a.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 3, "10:00 a.m. - 11:00 a.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 4, "11:00 a.m. - 12:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 5, "12:00 p.m. - 1:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 6, "1:00 p.m. - 2:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 7, "2:00 p.m. - 3:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 8, "3:00 p.m. - 4:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 9, "4:00 p.m. - 5:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 10, "5:00 p.m. - 6:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 11, "6:00 p.m. - 7:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 12, "7:00 p.m. - 8:00 p.m." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "TimeSlot" },
                values: new object[] { 13, "8:00 p.m. - 9:00 p.m." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Tourists");
        }
    }
}
