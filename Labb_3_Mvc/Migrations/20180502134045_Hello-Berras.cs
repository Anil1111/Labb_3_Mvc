using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Labb_3_Mvc.Migrations
{
    public partial class HelloBerras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeRange = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(maxLength: 32, nullable: true),
                    ImgUrl = table.Column<string>(maxLength: 32, nullable: true),
                    Length = table.Column<string>(maxLength: 32, nullable: true),
                    Title = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingTickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookingDate = table.Column<DateTime>(nullable: false),
                    MovieInfoId = table.Column<int>(nullable: true),
                    RoomInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingTickets_Movies_MovieInfoId",
                        column: x => x.MovieInfoId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingTickets_Rooms_RoomInfoId",
                        column: x => x.RoomInfoId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conjunction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(nullable: true),
                    Seats = table.Column<int>(nullable: false),
                    TicketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjunction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conjunction_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conjunction_BookingTickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "BookingTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingTickets_MovieInfoId",
                table: "BookingTickets",
                column: "MovieInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTickets_RoomInfoId",
                table: "BookingTickets",
                column: "RoomInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Conjunction_RoomId",
                table: "Conjunction",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Conjunction_TicketId",
                table: "Conjunction",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_MovieId",
                table: "Rooms",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conjunction");

            migrationBuilder.DropTable(
                name: "BookingTickets");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
