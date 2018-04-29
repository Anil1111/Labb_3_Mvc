using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Labb_3_Mvc.Migrations
{
    public partial class expandingaccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Conjunction",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Conjunction",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conjunction_ClientId",
                table: "Conjunction",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Conjunction_TicketId",
                table: "Conjunction",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conjunction_Clients_ClientId",
                table: "Conjunction",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conjunction_BookingTickets_TicketId",
                table: "Conjunction",
                column: "TicketId",
                principalTable: "BookingTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_Clients_ClientId",
                table: "Conjunction");

            migrationBuilder.DropForeignKey(
                name: "FK_Conjunction_BookingTickets_TicketId",
                table: "Conjunction");

            migrationBuilder.DropIndex(
                name: "IX_Conjunction_ClientId",
                table: "Conjunction");

            migrationBuilder.DropIndex(
                name: "IX_Conjunction_TicketId",
                table: "Conjunction");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Conjunction");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Conjunction");
        }
    }
}
