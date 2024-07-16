using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Topic.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_faq_edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "FAQs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
