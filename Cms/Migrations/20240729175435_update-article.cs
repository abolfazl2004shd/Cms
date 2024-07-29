using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Migrations
{
    /// <inheritdoc />
    public partial class updatearticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "ArticleComments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ArticleComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
