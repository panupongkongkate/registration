using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace registration.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterGender",
                columns: table => new
                {
                    GenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterGender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "MasterPosition",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPosition", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "RegImage",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConfirmPassword = table.Column<string>(nullable: true),
                    Dateofbirth = table.Column<DateTime>(nullable: true),
                    Phonenumber = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MasterGenderGenderId = table.Column<int>(nullable: true),
                    MasterPositionPositionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RegImage_MasterGender_MasterGenderGenderId",
                        column: x => x.MasterGenderGenderId,
                        principalTable: "MasterGender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegImage_MasterPosition_MasterPositionPositionId",
                        column: x => x.MasterPositionPositionId,
                        principalTable: "MasterPosition",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegImage_MasterGenderGenderId",
                table: "RegImage",
                column: "MasterGenderGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_RegImage_MasterPositionPositionId",
                table: "RegImage",
                column: "MasterPositionPositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegImage");

            migrationBuilder.DropTable(
                name: "MasterGender");

            migrationBuilder.DropTable(
                name: "MasterPosition");
        }
    }
}
