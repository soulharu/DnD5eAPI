using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DnD5e.API.Migrations
{
    public partial class apistart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    spellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    school = table.Column<string>(nullable: true),
                    castingTime = table.Column<string>(nullable: true),
                    range = table.Column<string>(nullable: true),
                    components = table.Column<string>(nullable: true),
                    materialComponentDescription = table.Column<string>(nullable: true),
                    duration = table.Column<string>(nullable: true),
                    isConcentration = table.Column<bool>(nullable: false),
                    isRitual = table.Column<bool>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    damage = table.Column<string>(nullable: true),
                    damageType = table.Column<string>(nullable: true),
                    hasHigherLevels = table.Column<bool>(nullable: false),
                    higherLevelDescription = table.Column<string>(nullable: true),
                    book = table.Column<string>(nullable: true),
                    page = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.spellId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spells");
        }
    }
}
