using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Boekingssysteem_API.Migrations
{
    /// <inheritdoc />
    public partial class api : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Boekingssysteem");

            migrationBuilder.CreateTable(
                name: "Functie",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    FunctieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functie", x => x.FunctieID);
                });

            migrationBuilder.CreateTable(
                name: "Persoon",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    Personeelnummer = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    Aanwezig = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoon", x => x.Personeelnummer);
                });

            migrationBuilder.CreateTable(
                name: "Richting",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    RichtingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Richting", x => x.RichtingID);
                });

            migrationBuilder.CreateTable(
                name: "Afwezigheid",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    AfwezigheidID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personeelnummer = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Begindatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindDatum = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afwezigheid", x => x.AfwezigheidID);
                    table.ForeignKey(
                        name: "FK_Afwezigheid_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoonFunctie",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    Personeelnummer = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FunctieID = table.Column<int>(type: "int", nullable: false),
                    PersoonFunctieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonFunctie", x => new { x.FunctieID, x.Personeelnummer });
                    table.ForeignKey(
                        name: "FK_PersoonFunctie_Functie_FunctieID",
                        column: x => x.FunctieID,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Functie",
                        principalColumn: "FunctieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonFunctie_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoonRichting",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    Personeelnummer = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    RichtingID = table.Column<int>(type: "int", nullable: false),
                    PersoonRichtingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonRichting", x => new { x.RichtingID, x.Personeelnummer });
                    table.ForeignKey(
                        name: "FK_PersoonRichting_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonRichting_Richting_RichtingID",
                        column: x => x.RichtingID,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Richting",
                        principalColumn: "RichtingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afwezigheid_Personeelnummer",
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFunctie_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichting_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                column: "Personeelnummer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afwezigheid",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "PersoonFunctie",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "PersoonRichting",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Functie",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Persoon",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Richting",
                schema: "Boekingssysteem");
        }
    }
}
