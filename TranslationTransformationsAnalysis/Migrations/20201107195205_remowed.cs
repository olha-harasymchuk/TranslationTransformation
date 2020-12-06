using Microsoft.EntityFrameworkCore.Migrations;

namespace TranslationTransformationsAnalysis.Migrations
{
    public partial class remowed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransformationUnitViewModel");

            migrationBuilder.DropTable(
                name: "ContextTypeViewModel");

            migrationBuilder.DropTable(
                name: "FormalTypeViewModel");

            migrationBuilder.DropTable(
                name: "PragmalTypeViewModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContextTypeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FonLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LekLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MorfLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SyntLevel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContextTypeViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormalTypeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FonLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LekLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MorfLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlovLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SyntLevel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormalTypeViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PragmalTypeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AxTransformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FraTtransformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoncTransformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MegTransformation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PragmalTypeViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransformationUnitViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContextTypeId = table.Column<int>(type: "int", nullable: true),
                    Formal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormalTypeId = table.Column<int>(type: "int", nullable: true),
                    Original = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pragmal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PragmalTypeId = table.Column<int>(type: "int", nullable: true),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransformationUnitViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransformationUnitViewModel_ContextTypeViewModel_ContextTypeId",
                        column: x => x.ContextTypeId,
                        principalTable: "ContextTypeViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransformationUnitViewModel_FormalTypeViewModel_FormalTypeId",
                        column: x => x.FormalTypeId,
                        principalTable: "FormalTypeViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransformationUnitViewModel_PragmalTypeViewModel_PragmalTypeId",
                        column: x => x.PragmalTypeId,
                        principalTable: "PragmalTypeViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransformationUnitViewModel_ContextTypeId",
                table: "TransformationUnitViewModel",
                column: "ContextTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationUnitViewModel_FormalTypeId",
                table: "TransformationUnitViewModel",
                column: "FormalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransformationUnitViewModel_PragmalTypeId",
                table: "TransformationUnitViewModel",
                column: "PragmalTypeId");
        }
    }
}
