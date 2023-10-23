using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundCartable.Migrations
{
    /// <inheritdoc />
    public partial class CreatDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "funds",
                columns: table => new
                {
                    Fund_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fund_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund_Count = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund_Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funds", x => x.Fund_Id);
                });

            migrationBuilder.CreateTable(
                name: "accountNumbers",
                columns: table => new
                {
                    AccountNumber_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund_Id = table.Column<int>(type: "int", nullable: false),
                    Fund_Id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountNumbers", x => x.AccountNumber_Id);
                    table.ForeignKey(
                        name: "FK_accountNumbers_funds_Fund_Id1",
                        column: x => x.Fund_Id1,
                        principalTable: "funds",
                        principalColumn: "Fund_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    Admin_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund_Id = table.Column<int>(type: "int", nullable: false),
                    Fund_Id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.Admin_ID);
                    table.ForeignKey(
                        name: "FK_admins_funds_Fund_Id1",
                        column: x => x.Fund_Id1,
                        principalTable: "funds",
                        principalColumn: "Fund_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phones",
                columns: table => new
                {
                    Phone_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund_Id = table.Column<int>(type: "int", nullable: false),
                    Fund_Id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phones", x => x.Phone_Id);
                    table.ForeignKey(
                        name: "FK_phones_funds_Fund_Id1",
                        column: x => x.Fund_Id1,
                        principalTable: "funds",
                        principalColumn: "Fund_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_AccountId = table.Column<int>(type: "int", nullable: false),
                    User_FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_IRCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_BirthDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund_Id = table.Column<int>(type: "int", nullable: false),
                    Fund_Id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.User_Id);
                    table.ForeignKey(
                        name: "FK_users_funds_Fund_Id1",
                        column: x => x.Fund_Id1,
                        principalTable: "funds",
                        principalColumn: "Fund_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "leons",
                columns: table => new
                {
                    Leon_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leon_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Leon_Term = table.Column<int>(type: "int", nullable: false),
                    Leon_DateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leon_DateEnded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leons", x => x.Leon_Id);
                    table.ForeignKey(
                        name: "FK_leons_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyProperty_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "installments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    LoanId = table.Column<int>(type: "int", nullable: false),
                    Leon_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_installments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_installments_leons_Leon_Id",
                        column: x => x.Leon_Id,
                        principalTable: "leons",
                        principalColumn: "Leon_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accountNumbers_Fund_Id1",
                table: "accountNumbers",
                column: "Fund_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_admins_Fund_Id1",
                table: "admins",
                column: "Fund_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_installments_Leon_Id",
                table: "installments",
                column: "Leon_Id");

            migrationBuilder.CreateIndex(
                name: "IX_leons_UserId",
                table: "leons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_UserId",
                table: "MyProperty",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_phones_Fund_Id1",
                table: "phones",
                column: "Fund_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_users_Fund_Id1",
                table: "users",
                column: "Fund_Id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountNumbers");

            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "installments");

            migrationBuilder.DropTable(
                name: "MyProperty");

            migrationBuilder.DropTable(
                name: "phones");

            migrationBuilder.DropTable(
                name: "leons");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "funds");
        }
    }
}
