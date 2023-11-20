using Microsoft.EntityFrameworkCore.Migrations;

namespace VendasWebMVC.Migrations
{
    public partial class MySQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "Seller",
                newName: "Departamentid");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "Basesalary");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartamentId",
                table: "Seller",
                newName: "IX_Seller_Departamentid");

            migrationBuilder.AlterColumn<int>(
                name: "Departamentid",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SaleStatus",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_Departamentid",
                table: "Seller",
                column: "Departamentid",
                principalTable: "Departament",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_Departamentid",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "SaleStatus",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "Departamentid",
                table: "Seller",
                newName: "DepartamentId");

            migrationBuilder.RenameColumn(
                name: "Basesalary",
                table: "Seller",
                newName: "BaseSalary");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_Departamentid",
                table: "Seller",
                newName: "IX_Seller_DepartamentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
