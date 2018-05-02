using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Labb_3_Mvc.Migrations
{
    public partial class MinorIdChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Movies_MovieInfoId",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Rooms_RoomInfoId",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_Rooms_RoomId",
                table: "Conjunction");

            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_BookingTickets_TicketId",
                table: "Conjunction");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Movies_MovieId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Seats",
                table: "Conjunction");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Rooms",
                newName: "MovieIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_MovieId",
                table: "Rooms",
                newName: "IX_Rooms_MovieIdId");

            migrationBuilder.RenameColumn(
                name: "AgeRange",
                table: "Movies",
                newName: "SeatsNr");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Conjunction",
                newName: "TicketIdId");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Conjunction",
                newName: "RoomIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Conjunction_TicketId",
                table: "Conjunction",
                newName: "IX_Conjunction_TicketIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Conjunction_RoomId",
                table: "Conjunction",
                newName: "IX_Conjunction_RoomIdId");

            migrationBuilder.RenameColumn(
                name: "RoomInfoId",
                table: "BookingTickets",
                newName: "RoomIdId");

            migrationBuilder.RenameColumn(
                name: "MovieInfoId",
                table: "BookingTickets",
                newName: "MovieIdId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_RoomInfoId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_RoomIdId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_MovieInfoId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_MovieIdId");

            migrationBuilder.AddColumn<int>(
                name: "AgeRangeNr",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Conjunction",
                maxLength: 32,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AgeRangeNr",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Status",
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
                name: "SeatsNr",
                table: "Movies",
                newName: "AgeRange");

            migrationBuilder.RenameColumn(
                name: "TicketIdId",
                table: "Conjunction",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "RoomIdId",
                table: "Conjunction",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Conjunction_TicketIdId",
                table: "Conjunction",
                newName: "IX_Conjunction_TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Conjunction_RoomIdId",
                table: "Conjunction",
                newName: "IX_Conjunction_RoomId");

            migrationBuilder.RenameColumn(
                name: "RoomIdId",
                table: "BookingTickets",
                newName: "RoomInfoId");

            migrationBuilder.RenameColumn(
                name: "MovieIdId",
                table: "BookingTickets",
                newName: "MovieInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_RoomIdId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_RoomInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingTickets_MovieIdId",
                table: "BookingTickets",
                newName: "IX_BookingTickets_MovieInfoId");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Rooms",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "Conjunction",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Movies_MovieInfoId",
                table: "BookingTickets",
                column: "MovieInfoId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Rooms_RoomInfoId",
                table: "BookingTickets",
                column: "RoomInfoId",
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
                name: "FK_Conjunction_BookingTickets_TicketId",
                table: "Conjunction",
                column: "TicketId",
                principalTable: "BookingTickets",
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
    }
}
