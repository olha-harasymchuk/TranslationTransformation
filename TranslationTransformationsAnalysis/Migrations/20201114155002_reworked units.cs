using Microsoft.EntityFrameworkCore.Migrations;

namespace TranslationTransformationsAnalysis.Migrations
{
    public partial class reworkedunits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransformationUnits_ContextTypes_ContextTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_TransformationUnits_FormalTypes_FormalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_TransformationUnits_PragmalTypes_PragmalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropIndex(
                name: "IX_TransformationUnits_ContextTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropIndex(
                name: "IX_TransformationUnits_FormalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropIndex(
                name: "IX_TransformationUnits_PragmalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "Context",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "ContextTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "Formal",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "FormalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "Pragmal",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "PragmalTypeId",
                table: "TransformationUnits");

            migrationBuilder.AddColumn<string>(
                name: "ContextFonLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContextLekLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContextMorfLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContextSyntLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormalFonLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormalLekLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormalMorfLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormalSlovLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormalSyntLevel",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PragmalAxTransformation",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PragmalKoncTransformation",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PragmalMegTransformation",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PragmalPragmalFraTtransformation",
                table: "TransformationUnits",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContextFonLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "ContextLekLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "ContextMorfLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "ContextSyntLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "FormalFonLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "FormalLekLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "FormalMorfLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "FormalSlovLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "FormalSyntLevel",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "PragmalAxTransformation",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "PragmalKoncTransformation",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "PragmalMegTransformation",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "PragmalPragmalFraTtransformation",
                table: "TransformationUnits");

            migrationBuilder.AddColumn<string>(
                name: "Context",
                table: "TransformationUnits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContextTypeId",
                table: "TransformationUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Formal",
                table: "TransformationUnits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormalTypeId",
                table: "TransformationUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pragmal",
                table: "TransformationUnits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PragmalTypeId",
                table: "TransformationUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransformationUnits_ContextTypeId",
                table: "TransformationUnits",
                column: "ContextTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationUnits_FormalTypeId",
                table: "TransformationUnits",
                column: "FormalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationUnits_PragmalTypeId",
                table: "TransformationUnits",
                column: "PragmalTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_ContextTypes_ContextTypeId",
                table: "TransformationUnits",
                column: "ContextTypeId",
                principalTable: "ContextTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_FormalTypes_FormalTypeId",
                table: "TransformationUnits",
                column: "FormalTypeId",
                principalTable: "FormalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_PragmalTypes_PragmalTypeId",
                table: "TransformationUnits",
                column: "PragmalTypeId",
                principalTable: "PragmalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
