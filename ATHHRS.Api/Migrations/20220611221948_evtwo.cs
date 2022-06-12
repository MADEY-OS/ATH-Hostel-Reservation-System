using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATHHRS.API.Migrations
{
    public partial class evtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentBegin",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "RentEnd",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "RentOrderTime",
                table: "Rents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RentBegin",
                table: "Rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RentEnd",
                table: "Rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RentOrderTime",
                table: "Rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
