using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTest.Migrations
{
    public partial class m02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Accounts_AccountIdId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "AccountIdId",
                table: "Carts",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_AccountIdId",
                table: "Carts",
                newName: "IX_Carts_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Accounts_AccountId",
                table: "Carts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Accounts_AccountId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Carts",
                newName: "AccountIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_AccountId",
                table: "Carts",
                newName: "IX_Carts_AccountIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Accounts_AccountIdId",
                table: "Carts",
                column: "AccountIdId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
