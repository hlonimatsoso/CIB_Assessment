using Microsoft.EntityFrameworkCore.Migrations;

namespace CIB.PhoneBookData.Migrations
{
    public partial class RequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneBookEntries_PhoneBooks_PhoneBookID",
                table: "PhoneBookEntries");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PhoneBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneBookID",
                table: "PhoneBookEntries",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneBookEntries_PhoneBooks_PhoneBookID",
                table: "PhoneBookEntries",
                column: "PhoneBookID",
                principalTable: "PhoneBooks",
                principalColumn: "PhoneBookID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneBookEntries_PhoneBooks_PhoneBookID",
                table: "PhoneBookEntries");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PhoneBooks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "PhoneBookID",
                table: "PhoneBookEntries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneBookEntries_PhoneBooks_PhoneBookID",
                table: "PhoneBookEntries",
                column: "PhoneBookID",
                principalTable: "PhoneBooks",
                principalColumn: "PhoneBookID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
