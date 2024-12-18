﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataaccesslayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_addcolumn_testimonial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "testimonials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "testimonials");
        }
    }
}
