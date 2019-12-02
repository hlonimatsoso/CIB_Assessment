using Microsoft.EntityFrameworkCore.Migrations;

namespace CIB.PhoneBookData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneBooks",
                columns: table => new
                {
                    PhoneBookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBooks", x => x.PhoneBookID);
                });

            migrationBuilder.CreateTable(
                name: "PhoneBookEntries",
                columns: table => new
                {
                    PhoneBookEntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numuber = table.Column<int>(nullable: false),
                    PhoneBookID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBookEntries", x => x.PhoneBookEntryID);
                    table.ForeignKey(
                        name: "FK_PhoneBookEntries_PhoneBooks_PhoneBookID",
                        column: x => x.PhoneBookID,
                        principalTable: "PhoneBooks",
                        principalColumn: "PhoneBookID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneBookEntries_PhoneBookID",
                table: "PhoneBookEntries",
                column: "PhoneBookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneBookEntries");

            migrationBuilder.DropTable(
                name: "PhoneBooks");
        }
    }
}
