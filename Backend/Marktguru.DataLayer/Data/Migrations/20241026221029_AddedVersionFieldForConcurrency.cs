using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marktguru.DataLayer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedVersionFieldForConcurrency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Version",
                table: "ProductModels",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "ProductModels");
        }
    }
}
