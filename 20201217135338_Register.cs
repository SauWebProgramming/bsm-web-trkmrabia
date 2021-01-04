using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatiShop.Migrations
{
    public partial class Register : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    RegisterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    EMail = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false),
                    RePassword = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    TermsAccepted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.RegisterID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
