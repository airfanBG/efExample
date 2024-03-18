using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommercialStuffs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommercialStuffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    GenreType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSongs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ArtistId = table.Column<string>(type: "text", nullable: false),
                    SongId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreSongs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    GenreId = table.Column<string>(type: "text", nullable: false),
                    SongId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreSongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenreSongs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountKeys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: false),
                    Discount = table.Column<decimal>(type: "numeric", nullable: false),
                    OrderId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountKeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountKeys_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "22ecb652-02a4-443d-bda2-b87110b1e6a3", "Iggy pop" },
                    { "c9edb6ef-a960-4804-9509-009b8afb01e4", "Pink floyd" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "GenreType" },
                values: new object[,]
                {
                    { "4dae8ae7-ab6a-4492-9bbb-c763b4d16f60", "Pop" },
                    { "c4e2e8bd-b4a9-46ce-935e-a32bd978dfca", "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "Image", "Title", "Year" },
                values: new object[,]
                {
                    { "804bcc44-2298-4010-91af-d8b98c3aa11d", 1100, "url", "Hello", 2000 },
                    { "8924356d-f9a5-407e-b3c7-659f3486bf12", 3451, "url", "Test", 2005 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Username" },
                values: new object[,]
                {
                    { "145520a3-281b-4186-8a82-3c1ec51d0fd4", "Gosho" },
                    { "9bb7691d-8eb7-49c1-bcc4-4d643bdf5c75", "Pesho" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[] { "82347660-2457-42e4-889a-03eed623499a", "22ecb652-02a4-443d-bda2-b87110b1e6a3", "804bcc44-2298-4010-91af-d8b98c3aa11d" });

            migrationBuilder.InsertData(
                table: "GenreSongs",
                columns: new[] { "Id", "GenreId", "SongId" },
                values: new object[] { "5cb38899-6b77-4a99-9f57-bc2527b3f7cf", "4dae8ae7-ab6a-4492-9bbb-c763b4d16f60", "804bcc44-2298-4010-91af-d8b98c3aa11d" });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSongs_ArtistId",
                table: "ArtistSongs",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSongs_SongId",
                table: "ArtistSongs",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountKeys_OrderId",
                table: "DiscountKeys",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreSongs_GenreId",
                table: "GenreSongs",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreSongs_SongId",
                table: "GenreSongs",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSongs");

            migrationBuilder.DropTable(
                name: "CommercialStuffs");

            migrationBuilder.DropTable(
                name: "DiscountKeys");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "GenreSongs");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
