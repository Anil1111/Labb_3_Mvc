using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Labb_3_Mvc.Migrations
{
    public partial class Morechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Movies_MovieId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_MovieId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "AgeRangeNr",
                table: "Movies",
                newName: "AgeRange");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Conjunction",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conjunction_MovieId",
                table: "Conjunction",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conjunction_Movies_MovieId",
                table: "Conjunction",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_Movies_MovieId",
                table: "Conjunction");

            migrationBuilder.DropIndex(
                name: "IX_Conjunction_MovieId",
                table: "Conjunction");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Conjunction");

            migrationBuilder.RenameColumn(
                name: "AgeRange",
                table: "Movies",
                newName: "AgeRangeNr");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_MovieId",
                table: "Rooms",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Movies_MovieId",
                table: "Rooms",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
