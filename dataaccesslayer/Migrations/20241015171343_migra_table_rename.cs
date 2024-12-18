using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataaccesslayer.Migrations
{
    /// <inheritdoc />
    public partial class migra_table_rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contactss",
                table: "contactss");

            migrationBuilder.RenameTable(
                name: "contactss",
                newName: "contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "concactID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.RenameTable(
                name: "contacts",
                newName: "contactss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contactss",
                table: "contactss",
                column: "concactID");
        }
    }
}
