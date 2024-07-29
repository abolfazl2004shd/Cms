using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Migrations
{
    /// <inheritdoc />
    public partial class correctprop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Context",
                table: "Articles",
                newName: "Content");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Articles",
                newName: "Context");
        }
    }
}
