using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataaccesslayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_column_portfolio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageUrl2",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "projectrl",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrl2",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "projectrl",
                table: "portfolios");
        }
    }
}
