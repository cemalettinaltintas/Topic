using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Topic.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_contact_mapurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MapUrl",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapUrl",
                table: "Contacts");
        }
    }
}
