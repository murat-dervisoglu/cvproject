using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataaccesslayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_project_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image1",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "image2",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "image3",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "image4",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "platform",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "price",
                table: "portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "satutus",
                table: "portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image1",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "image2",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "image3",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "image4",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "platform",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "price",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "satutus",
                table: "portfolios");

            migrationBuilder.DropColumn(
                name: "value",
                table: "portfolios");
        }
    }
}
