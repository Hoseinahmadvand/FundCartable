using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundCartable.Migrations
{
    /// <inheritdoc />
    public partial class updatDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_users_UserId",
                table: "MyProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Monthlies");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_UserId",
                table: "Monthlies",
                newName: "IX_Monthlies_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monthlies",
                table: "Monthlies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Monthlies_users_UserId",
                table: "Monthlies",
                column: "UserId",
                principalTable: "users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monthlies_users_UserId",
                table: "Monthlies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monthlies",
                table: "Monthlies");

            migrationBuilder.RenameTable(
                name: "Monthlies",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_Monthlies_UserId",
                table: "MyProperty",
                newName: "IX_MyProperty_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_users_UserId",
                table: "MyProperty",
                column: "UserId",
                principalTable: "users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
