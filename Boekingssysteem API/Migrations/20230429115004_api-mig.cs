using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Boekingssysteem_API.Migrations
{
    /// <inheritdoc />
    public partial class apimig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Afwezigheid_Persoon_Personeelnummer",
                schema: "Boekingssysteem",
                table: "Afwezigheid");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonFunctie_Functie_FunctieID",
                schema: "Boekingssysteem",
                table: "PersoonFunctie");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonFunctie_Persoon_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonFunctie");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonRichting_Persoon_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonRichting");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonRichting_Richting_RichtingID",
                schema: "Boekingssysteem",
                table: "PersoonRichting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Richting",
                schema: "Boekingssysteem",
                table: "Richting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonRichting",
                schema: "Boekingssysteem",
                table: "PersoonRichting");

            migrationBuilder.DropIndex(
                name: "IX_PersoonRichting_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonRichting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonFunctie",
                schema: "Boekingssysteem",
                table: "PersoonFunctie");

            migrationBuilder.DropIndex(
                name: "IX_PersoonFunctie_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonFunctie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persoon",
                schema: "Boekingssysteem",
                table: "Persoon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Functie",
                schema: "Boekingssysteem",
                table: "Functie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Afwezigheid",
                schema: "Boekingssysteem",
                table: "Afwezigheid");

            migrationBuilder.DropIndex(
                name: "IX_Afwezigheid_Personeelnummer",
                schema: "Boekingssysteem",
                table: "Afwezigheid");

            migrationBuilder.RenameTable(
                name: "Richting",
                schema: "Boekingssysteem",
                newName: "Richtingen");

            migrationBuilder.RenameTable(
                name: "PersoonRichting",
                schema: "Boekingssysteem",
                newName: "PersoonRichtingen");

            migrationBuilder.RenameTable(
                name: "PersoonFunctie",
                schema: "Boekingssysteem",
                newName: "PersoonFuncties");

            migrationBuilder.RenameTable(
                name: "Persoon",
                schema: "Boekingssysteem",
                newName: "Personen");

            migrationBuilder.RenameTable(
                name: "Functie",
                schema: "Boekingssysteem",
                newName: "Functies");

            migrationBuilder.RenameTable(
                name: "Afwezigheid",
                schema: "Boekingssysteem",
                newName: "Afwezigheden");

            migrationBuilder.AlterColumn<int>(
                name: "PersoonRichtingID",
                table: "PersoonRichtingen",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "PersoonPersoneelnummer",
                table: "PersoonRichtingen",
                type: "nvarchar(8)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersoonFunctieID",
                table: "PersoonFuncties",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "PersoonPersoneelnummer",
                table: "PersoonFuncties",
                type: "nvarchar(8)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersoonPersoneelnummer",
                table: "Afwezigheden",
                type: "nvarchar(8)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Richtingen",
                table: "Richtingen",
                column: "RichtingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonRichtingen",
                table: "PersoonRichtingen",
                column: "PersoonRichtingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonFuncties",
                table: "PersoonFuncties",
                column: "PersoonFunctieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personen",
                table: "Personen",
                column: "Personeelnummer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Functies",
                table: "Functies",
                column: "FunctieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Afwezigheden",
                table: "Afwezigheden",
                column: "AfwezigheidID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichtingen_PersoonPersoneelnummer",
                table: "PersoonRichtingen",
                column: "PersoonPersoneelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichtingen_RichtingID",
                table: "PersoonRichtingen",
                column: "RichtingID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFuncties_FunctieID",
                table: "PersoonFuncties",
                column: "FunctieID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFuncties_PersoonPersoneelnummer",
                table: "PersoonFuncties",
                column: "PersoonPersoneelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_Afwezigheden_PersoonPersoneelnummer",
                table: "Afwezigheden",
                column: "PersoonPersoneelnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Afwezigheden_Personen_PersoonPersoneelnummer",
                table: "Afwezigheden",
                column: "PersoonPersoneelnummer",
                principalTable: "Personen",
                principalColumn: "Personeelnummer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonFuncties_Functies_FunctieID",
                table: "PersoonFuncties",
                column: "FunctieID",
                principalTable: "Functies",
                principalColumn: "FunctieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonFuncties_Personen_PersoonPersoneelnummer",
                table: "PersoonFuncties",
                column: "PersoonPersoneelnummer",
                principalTable: "Personen",
                principalColumn: "Personeelnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonRichtingen_Personen_PersoonPersoneelnummer",
                table: "PersoonRichtingen",
                column: "PersoonPersoneelnummer",
                principalTable: "Personen",
                principalColumn: "Personeelnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonRichtingen_Richtingen_RichtingID",
                table: "PersoonRichtingen",
                column: "RichtingID",
                principalTable: "Richtingen",
                principalColumn: "RichtingID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Afwezigheden_Personen_PersoonPersoneelnummer",
                table: "Afwezigheden");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonFuncties_Functies_FunctieID",
                table: "PersoonFuncties");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonFuncties_Personen_PersoonPersoneelnummer",
                table: "PersoonFuncties");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonRichtingen_Personen_PersoonPersoneelnummer",
                table: "PersoonRichtingen");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonRichtingen_Richtingen_RichtingID",
                table: "PersoonRichtingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Richtingen",
                table: "Richtingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonRichtingen",
                table: "PersoonRichtingen");

            migrationBuilder.DropIndex(
                name: "IX_PersoonRichtingen_PersoonPersoneelnummer",
                table: "PersoonRichtingen");

            migrationBuilder.DropIndex(
                name: "IX_PersoonRichtingen_RichtingID",
                table: "PersoonRichtingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonFuncties",
                table: "PersoonFuncties");

            migrationBuilder.DropIndex(
                name: "IX_PersoonFuncties_FunctieID",
                table: "PersoonFuncties");

            migrationBuilder.DropIndex(
                name: "IX_PersoonFuncties_PersoonPersoneelnummer",
                table: "PersoonFuncties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personen",
                table: "Personen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Functies",
                table: "Functies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Afwezigheden",
                table: "Afwezigheden");

            migrationBuilder.DropIndex(
                name: "IX_Afwezigheden_PersoonPersoneelnummer",
                table: "Afwezigheden");

            migrationBuilder.DropColumn(
                name: "PersoonPersoneelnummer",
                table: "PersoonRichtingen");

            migrationBuilder.DropColumn(
                name: "PersoonPersoneelnummer",
                table: "PersoonFuncties");

            migrationBuilder.DropColumn(
                name: "PersoonPersoneelnummer",
                table: "Afwezigheden");

            migrationBuilder.EnsureSchema(
                name: "Boekingssysteem");

            migrationBuilder.RenameTable(
                name: "Richtingen",
                newName: "Richting",
                newSchema: "Boekingssysteem");

            migrationBuilder.RenameTable(
                name: "PersoonRichtingen",
                newName: "PersoonRichting",
                newSchema: "Boekingssysteem");

            migrationBuilder.RenameTable(
                name: "PersoonFuncties",
                newName: "PersoonFunctie",
                newSchema: "Boekingssysteem");

            migrationBuilder.RenameTable(
                name: "Personen",
                newName: "Persoon",
                newSchema: "Boekingssysteem");

            migrationBuilder.RenameTable(
                name: "Functies",
                newName: "Functie",
                newSchema: "Boekingssysteem");

            migrationBuilder.RenameTable(
                name: "Afwezigheden",
                newName: "Afwezigheid",
                newSchema: "Boekingssysteem");

            migrationBuilder.AlterColumn<int>(
                name: "PersoonRichtingID",
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PersoonFunctieID",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Richting",
                schema: "Boekingssysteem",
                table: "Richting",
                column: "RichtingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonRichting",
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                columns: new[] { "RichtingID", "Personeelnummer" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonFunctie",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                columns: new[] { "FunctieID", "Personeelnummer" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persoon",
                schema: "Boekingssysteem",
                table: "Persoon",
                column: "Personeelnummer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Functie",
                schema: "Boekingssysteem",
                table: "Functie",
                column: "FunctieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Afwezigheid",
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                column: "AfwezigheidID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichting_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFunctie_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_Afwezigheid_Personeelnummer",
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                column: "Personeelnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Afwezigheid_Persoon_Personeelnummer",
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                column: "Personeelnummer",
                principalSchema: "Boekingssysteem",
                principalTable: "Persoon",
                principalColumn: "Personeelnummer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonFunctie_Functie_FunctieID",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                column: "FunctieID",
                principalSchema: "Boekingssysteem",
                principalTable: "Functie",
                principalColumn: "FunctieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonFunctie_Persoon_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                column: "Personeelnummer",
                principalSchema: "Boekingssysteem",
                principalTable: "Persoon",
                principalColumn: "Personeelnummer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonRichting_Persoon_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                column: "Personeelnummer",
                principalSchema: "Boekingssysteem",
                principalTable: "Persoon",
                principalColumn: "Personeelnummer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonRichting_Richting_RichtingID",
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                column: "RichtingID",
                principalSchema: "Boekingssysteem",
                principalTable: "Richting",
                principalColumn: "RichtingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
