using Microsoft.EntityFrameworkCore.Migrations;

namespace TranslationTransformationsAnalysis.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransformationUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Original = table.Column<string>(nullable: false),
                    Translation = table.Column<string>(nullable: false),
                    Formal = table.Column<string>(nullable: true),
                    Context = table.Column<string>(nullable: true),
                    Pragmal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransformationUnits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransformationUnits");
        }
    }
}
