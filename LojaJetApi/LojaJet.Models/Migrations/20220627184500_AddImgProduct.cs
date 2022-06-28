using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaJet.Models.Migrations
{
    public partial class AddImgProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "principal_img",
                table: "tb_product",
                type: "longblob",
                nullable: false);

            migrationBuilder.AddColumn<double>(
                name: "promocional_price",
                table: "tb_product",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<byte[]>(
                name: "secundary_img",
                table: "tb_product",
                type: "longblob",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "principal_img",
                table: "tb_product");

            migrationBuilder.DropColumn(
                name: "promocional_price",
                table: "tb_product");

            migrationBuilder.DropColumn(
                name: "secundary_img",
                table: "tb_product");
        }
    }
}
