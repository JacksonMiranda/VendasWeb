using Microsoft.EntityFrameworkCore.Migrations;

namespace VendasWebMVC.Migrations
{
    public partial class MySQLAjusts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_Departamentid",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Departamentid",
                table: "Seller",
                newName: "DepartamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_Departamentid",
                table: "Seller",
                newName: "IX_Seller_DepartamentId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Departament",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "Seller",
                newName: "Departamentid");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartamentId",
                table: "Seller",
                newName: "IX_Seller_Departamentid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departament",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_Departamentid",
                table: "Seller",
                column: "Departamentid",
                principalTable: "Departament",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
