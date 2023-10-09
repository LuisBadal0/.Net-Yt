using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingWebApp.Data.Migrations
{
    public partial class newUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "Joke");
        }
    }
}
