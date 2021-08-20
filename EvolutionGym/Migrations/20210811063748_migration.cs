using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EvolutionGym.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblClient",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientRut = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ClientFatherLastName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ClientMotherLastName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ClientEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientPhone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClient", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "tblPaymentMethod",
                columns: table => new
                {
                    PaymentMethodID = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MethodDesc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPaymentMethod", x => x.PaymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "tblRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleDesc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRole", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "tblTypeMembership",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDesc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTypeMembership", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRut = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UserUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserPass = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    UserFatherLastName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    UserMotherLastName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_tblUser_tblRole_RoleID",
                        column: x => x.RoleID,
                        principalTable: "tblRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMembership",
                columns: table => new
                {
                    MembershipID = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipDateBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MembershipDateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMembership", x => x.MembershipID);
                    table.ForeignKey(
                        name: "FK_tblMembership_tblClient_ClientID",
                        column: x => x.ClientID,
                        principalTable: "tblClient",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMembership_tblPaymentMethod_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "tblPaymentMethod",
                        principalColumn: "PaymentMethodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMembership_tblTypeMembership_TypeID",
                        column: x => x.TypeID,
                        principalTable: "tblTypeMembership",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMembership_tblUser_UserID",
                        column: x => x.UserID,
                        principalTable: "tblUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblMembership_ClientID",
                table: "tblMembership",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMembership_PaymentMethodID",
                table: "tblMembership",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMembership_TypeID",
                table: "tblMembership",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMembership_UserID",
                table: "tblMembership",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tblUser_RoleID",
                table: "tblUser",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblMembership");

            migrationBuilder.DropTable(
                name: "tblClient");

            migrationBuilder.DropTable(
                name: "tblPaymentMethod");

            migrationBuilder.DropTable(
                name: "tblTypeMembership");

            migrationBuilder.DropTable(
                name: "tblUser");

            migrationBuilder.DropTable(
                name: "tblRole");
        }
    }
}
