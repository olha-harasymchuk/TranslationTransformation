using Microsoft.EntityFrameworkCore.Migrations;

namespace TranslationTransformationsAnalysis.Migrations
{
    public partial class reworkedid : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "PragmalTypeId",
                table: "TransformationUnits",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FormalTypeId",
                table: "TransformationUnits",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContextTypeId",
                table: "TransformationUnits",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "PragmalTypeId",
                table: "TransformationUnits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FormalTypeId",
                table: "TransformationUnits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ContextTypeId",
                table: "TransformationUnits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
