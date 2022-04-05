using Microsoft.EntityFrameworkCore.Migrations;

namespace Read_EDI_Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISA = table.Column<string>(nullable: true),
                    GS = table.Column<string>(nullable: true),
                    ST = table.Column<string>(nullable: true),
                    Big = table.Column<string>(nullable: true),
                    N1 = table.Column<string>(nullable: true),
                    N3 = table.Column<string>(nullable: true),
                    N4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ports");
        }
    }
}
