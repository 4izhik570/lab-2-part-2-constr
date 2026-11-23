using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2_Part3.Migrations
{
    /// <inheritdoc />
    public partial class AddPostalIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostalIndex",
                table: "streets",
                type: "char(6)",
                maxLength: 6,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "streets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostalIndex",
                value: null);

            migrationBuilder.UpdateData(
                table: "streets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostalIndex",
                value: null);

            migrationBuilder.UpdateData(
                table: "streets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostalIndex",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalIndex",
                table: "streets");
        }
    }
}
