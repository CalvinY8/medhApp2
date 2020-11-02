using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    BCITID = table.Column<string>(nullable: false),
                    MobileNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Option = table.Column<string>(nullable: false),
                    Set = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BCITID", "City", "Email", "FirstName", "LastName", "MobileNo", "Option", "Set" },
                values: new object[,]
                {
                    { "ec6ca32f-e5ad-40a3-b236-8e8fa73eb03e", "A00123448", "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Web & Mobile", "S" },
                    { "b80e193c-748e-4ff9-ac73-eac79f19a10c", "A00816734", "Capillano", "will@smith.com", "Will", "Smith", "604-111-1111", "Mechatronics", "V" },
                    { "71d30492-e04a-4f88-8ab4-8d197c49bde5", "A00648317", "Victoria", "tim@james.com", "Tim", "James", "604-222-2222", "Mechatronics", "v" },
                    { "9ce3572e-3898-4736-8fe8-069c7eefb630", "A00123451", "Mission", "sarah@parker.com", "Sarah", "Parker", "604-333-3333", "Web & Mobile", "S" },
                    { "7e780f84-6090-43ba-bc6c-850d8e771795", "A00123452", "Vancouver", "ricky@low.com", "Ricky", "Low", "604-444-4444", "AI", "F" },
                    { "72e22b35-29e0-4707-8b02-84a3b39f0e86", "A00123453", "Burnaby", "terry@crews.com", "Terry", "Crews", "604-555-5555", "AI", "F" },
                    { "709208d3-a4f1-492d-9138-e51d4fb66ed2", "A00123454", "Los Angeles", "jerry@wither.com", "Jerry", "Wither", "604-666-6666", "Web & Mobile", "S" },
                    { "4cedf42d-8371-408a-8f24-e2d32c974416", "A00123455", "Langley", "jones@potter.com", "Jones", "Potter", "604-777-7777", "Web & Mobile", "S" },
                    { "d313f82a-781e-44e3-948f-e6e488112bc8", "A00123456", "Surrey", "Lana@DelRay.com", "Lana", "DelRay", "604-888-8888", "Tech Entrepeneur", "G" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
