using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.Migrations
{
    /// <inheritdoc />
    public partial class AddGoogleBookIdToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleBookId",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_GoogleBookId",
                table: "Books",
                column: "GoogleBookId",
                unique: true,
                filter: "[GoogleBookId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_GoogleBookId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "GoogleBookId",
                table: "Books");
        }
    }
}
