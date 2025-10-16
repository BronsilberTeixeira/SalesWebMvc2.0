using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class departmentFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_sellerid",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_departmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Seller",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Seller",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Seller",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "Seller",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "baseSalary",
                table: "Seller",
                newName: "BaseSalary");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Seller",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_departmentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "sellerid",
                table: "SalesRecord",
                newName: "sellerId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_sellerid",
                table: "SalesRecord",
                newName: "IX_SalesRecord_sellerId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_sellerId",
                table: "SalesRecord",
                column: "sellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_sellerId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Seller",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Seller",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Seller",
                newName: "departmentId");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Seller",
                newName: "birthDate");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "baseSalary");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Seller",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_departmentId");

            migrationBuilder.RenameColumn(
                name: "sellerId",
                table: "SalesRecord",
                newName: "sellerid");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_sellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_sellerid");

            migrationBuilder.AlterColumn<int>(
                name: "departmentId",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_sellerid",
                table: "SalesRecord",
                column: "sellerid",
                principalTable: "Seller",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_departmentId",
                table: "Seller",
                column: "departmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
