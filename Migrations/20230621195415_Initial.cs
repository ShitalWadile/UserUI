using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Azure_Portal.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    C_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Application_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Application_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blackout_Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Serverinfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portinfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.C_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
