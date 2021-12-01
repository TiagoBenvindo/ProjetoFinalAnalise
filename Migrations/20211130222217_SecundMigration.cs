using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalAnalise.Migrations
{
    public partial class SecundMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "seller",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sellerId",
                table: "salesRecord",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_seller_departmentId",
                table: "seller",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_salesRecord_sellerId",
                table: "salesRecord",
                column: "sellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_salesRecord_seller_sellerId",
                table: "salesRecord",
                column: "sellerId",
                principalTable: "seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_seller_department_departmentId",
                table: "seller",
                column: "departmentId",
                principalTable: "department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salesRecord_seller_sellerId",
                table: "salesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_seller_department_departmentId",
                table: "seller");

            migrationBuilder.DropIndex(
                name: "IX_seller_departmentId",
                table: "seller");

            migrationBuilder.DropIndex(
                name: "IX_salesRecord_sellerId",
                table: "salesRecord");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "seller");

            migrationBuilder.DropColumn(
                name: "sellerId",
                table: "salesRecord");
        }
    }
}
