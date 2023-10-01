using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAppHexagon.Adapaters.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "TodoItems",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "TodoItems");
        }
    }
}
