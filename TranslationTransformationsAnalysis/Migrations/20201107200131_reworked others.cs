using Microsoft.EntityFrameworkCore.Migrations;

namespace TranslationTransformationsAnalysis.Migrations
{
    public partial class reworkedothers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransformationUnits_ContextType_ContextTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_TransformationUnits_FormalType_FormalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_TransformationUnits_PragmalType_PragmalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PragmalType",
                table: "PragmalType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormalType",
                table: "FormalType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContextType",
                table: "ContextType");

            migrationBuilder.RenameTable(
                name: "PragmalType",
                newName: "PragmalTypes");

            migrationBuilder.RenameTable(
                name: "FormalType",
                newName: "FormalTypes");

            migrationBuilder.RenameTable(
                name: "ContextType",
                newName: "ContextTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PragmalTypes",
                table: "PragmalTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormalTypes",
                table: "FormalTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContextTypes",
                table: "ContextTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_ContextTypes_ContextTypeId",
                table: "TransformationUnits",
                column: "ContextTypeId",
                principalTable: "ContextTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_FormalTypes_FormalTypeId",
                table: "TransformationUnits",
                column: "FormalTypeId",
                principalTable: "FormalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_PragmalTypes_PragmalTypeId",
                table: "TransformationUnits",
                column: "PragmalTypeId",
                principalTable: "PragmalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_PragmalTypes",
                table: "PragmalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormalTypes",
                table: "FormalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContextTypes",
                table: "ContextTypes");

            migrationBuilder.RenameTable(
                name: "PragmalTypes",
                newName: "PragmalType");

            migrationBuilder.RenameTable(
                name: "FormalTypes",
                newName: "FormalType");

            migrationBuilder.RenameTable(
                name: "ContextTypes",
                newName: "ContextType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PragmalType",
                table: "PragmalType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormalType",
                table: "FormalType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContextType",
                table: "ContextType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_ContextType_ContextTypeId",
                table: "TransformationUnits",
                column: "ContextTypeId",
                principalTable: "ContextType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_FormalType_FormalTypeId",
                table: "TransformationUnits",
                column: "FormalTypeId",
                principalTable: "FormalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransformationUnits_PragmalType_PragmalTypeId",
                table: "TransformationUnits",
                column: "PragmalTypeId",
                principalTable: "PragmalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
