using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Labb_3_Mvc.Migrations
{
    public partial class MajorIdChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Movies_MovieIdId",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Rooms_RoomIdId",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_Rooms_RoomIdId",
                table: "Conjunction");

            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_BookingTickets_TicketIdId",
                table: "Conjunction");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Movies_MovieIdId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Conjunction_RoomIdId",
                table: "Conjunction");

            migrationBuilder.DropColumn(
                name: "RoomIdId",
                table: "Conjunction");

            migrationBuilder.RenameColumn(
                name: "MovieIdId",
                table: "Rooms",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_MovieIdId",
                table: "Rooms",
                newName: "IX_Rooms_MovieId");

            migrationBuilder.RenameColumn(
                name: "TicketIdId",
                table: "Conjunction",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Conjunction_TicketIdId",
                table: "Conjunction",
                newName: "IX_Conjunction_RoomId");

            migrationBuilder.RenameColumn(
                name: "RoomIdId",
                table: "BookingTickets",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "MovieIdId",
                table: "BookingTickets",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_RoomIdId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_MovieIdId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Movies_MovieId",
                table: "BookingTickets",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Rooms_RoomId",
                table: "BookingTickets",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conjunction_Rooms_RoomId",
                table: "Conjunction",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Movies_MovieId",
                table: "Rooms",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Movies_MovieId",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Rooms_RoomId",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_Rooms_RoomId",
                table: "Conjunction");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Movies_MovieId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Rooms",
                newName: "MovieIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_MovieId",
                table: "Rooms",
                newName: "IX_Rooms_MovieIdId");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Conjunction",
                newName: "TicketIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Conjunction_RoomId",
                table: "Conjunction",
                newName: "IX_Conjunction_TicketIdId");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "BookingTickets",
                newName: "RoomIdId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "BookingTickets",
                newName: "MovieIdId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_RoomId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_RoomIdId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_MovieId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_MovieIdId");

            migrationBuilder.AddColumn<int>(
                name: "RoomIdId",
                table: "Conjunction",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conjunction_RoomIdId",
                table: "Conjunction",
                column: "RoomIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Movies_MovieIdId",
                table: "BookingTickets",
                column: "MovieIdId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Rooms_RoomIdId",
                table: "BookingTickets",
                column: "RoomIdId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conjunction_Rooms_RoomIdId",
                table: "Conjunction",
                column: "RoomIdId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conjunction_BookingTickets_TicketIdId",
                table: "Conjunction",
                column: "TicketIdId",
                principalTable: "BookingTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Movies_MovieIdId",
                table: "Rooms",
                column: "MovieIdId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
