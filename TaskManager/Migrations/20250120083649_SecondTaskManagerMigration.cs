using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class SecondTaskManagerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Taskcategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taskcategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_CategoryId",
                table: "Task",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Taskcategory_CategoryId",
                table: "Task",
                column: "CategoryId",
                principalTable: "Taskcategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Taskcategory_CategoryId",
                table: "Task");

            migrationBuilder.DropTable(
                name: "Taskcategory");

            migrationBuilder.DropIndex(
                name: "IX_Task_CategoryId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Task");
        }
    }
}
