using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTest.Migrations
{
    public partial class m01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "AccountIdId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AccountIdId",
                table: "Carts",
                column: "AccountIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Accounts_AccountIdId",
                table: "Carts",
                column: "AccountIdId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Accounts_AccountIdId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_AccountIdId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "AccountIdId",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
