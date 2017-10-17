using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class Changecolumnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_GetLibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropIndex(
                name: "IX_CheckoutHistories_GetLibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropColumn(
                name: "GetLibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.AddColumn<int>(
                name: "LibraryAssetId",
                table: "CheckoutHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_LibraryAssetId",
                table: "CheckoutHistories",
                column: "LibraryAssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropIndex(
                name: "IX_CheckoutHistories_LibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropColumn(
                name: "LibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.AddColumn<int>(
                name: "GetLibraryAssetId",
                table: "CheckoutHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_GetLibraryAssetId",
                table: "CheckoutHistories",
                column: "GetLibraryAssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_GetLibraryAssetId",
                table: "CheckoutHistories",
                column: "GetLibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
