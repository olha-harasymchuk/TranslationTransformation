using Microsoft.EntityFrameworkCore.Migrations;

namespace TranslationTransformationsAnalysis.Migrations
{
    public partial class reworked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContextTypeId",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormalTypeId",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PragmalTypeId",
                table: "TransformationUnits",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContextType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FonLevel = table.Column<string>(nullable: true),
                    LekLevel = table.Column<string>(nullable: true),
                    MorfLevel = table.Column<string>(nullable: true),
                    SyntLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContextType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContextTypeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FonLevel = table.Column<string>(nullable: true),
                    LekLevel = table.Column<string>(nullable: true),
                    MorfLevel = table.Column<string>(nullable: true),
                    SyntLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContextTypeViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormalType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FonLevel = table.Column<string>(nullable: true),
                    SlovLevel = table.Column<string>(nullable: true),
                    LekLevel = table.Column<string>(nullable: true),
                    MorfLevel = table.Column<string>(nullable: true),
                    SyntLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormalTypeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FonLevel = table.Column<string>(nullable: true),
                    SlovLevel = table.Column<string>(nullable: true),
                    LekLevel = table.Column<string>(nullable: true),
                    MorfLevel = table.Column<string>(nullable: true),
                    SyntLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormalTypeViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PragmalType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FraTtransformation = table.Column<string>(nullable: true),
                    KoncTransformation = table.Column<string>(nullable: true),
                    AxTransformation = table.Column<string>(nullable: true),
                    MegTransformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PragmalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PragmalTypeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FraTtransformation = table.Column<string>(nullable: true),
                    KoncTransformation = table.Column<string>(nullable: true),
                    AxTransformation = table.Column<string>(nullable: true),
                    MegTransformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PragmalTypeViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransformationUnitViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Original = table.Column<string>(nullable: true),
                    Translation = table.Column<string>(nullable: true),
                    Formal = table.Column<string>(nullable: true),
                    Context = table.Column<string>(nullable: true),
                    Pragmal = table.Column<string>(nullable: true),
                    ContextTypeId = table.Column<int>(nullable: true),
                    FormalTypeId = table.Column<int>(nullable: true),
                    PragmalTypeId = table.Column<int>(nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "ContextType");

            migrationBuilder.DropTable(
                name: "FormalType");

            migrationBuilder.DropTable(
                name: "PragmalType");

            migrationBuilder.DropTable(
                name: "TransformationUnitViewModel");

            migrationBuilder.DropTable(
                name: "ContextTypeViewModel");

            migrationBuilder.DropTable(
                name: "FormalTypeViewModel");

            migrationBuilder.DropTable(
                name: "PragmalTypeViewModel");

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
                name: "ContextTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "FormalTypeId",
                table: "TransformationUnits");

            migrationBuilder.DropColumn(
                name: "PragmalTypeId",
                table: "TransformationUnits");
        }
    }
}
