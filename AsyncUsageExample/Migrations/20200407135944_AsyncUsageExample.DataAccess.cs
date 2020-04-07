using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncUsageExample.Migrations
{
    public partial class AsyncUsageExampleDataAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SampleEntities",
                columns: table => new
                {
                    Entity1Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field1 = table.Column<string>(nullable: true),
                    Field2 = table.Column<string>(nullable: true),
                    Field3 = table.Column<string>(nullable: true),
                    Field4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleEntities", x => x.Entity1Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SampleEntities");
        }
    }
}
