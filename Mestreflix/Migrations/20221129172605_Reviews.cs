using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mestreflix.Migrations
{
    public partial class Reviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Top Gun - Maverick");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Email", "FullName", "MovieId", "Text" },
                values: new object[] { 1, "renato.mestre@hotmail.com", "Renato Mestre", 1, "Achei bem bacana, inclusive para a época!\nLançou no mês que eu nasci..." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "TopGun - Maverick");
        }
    }
}
