using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerConnectionsApp.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chrCode = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    strAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strJobNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strConnectionApplication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strConnectionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strAdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intCustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Customers_intCustomerId",
                        column: x => x.intCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hardwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strSubnetMask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strDefaultGateway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intJobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hardwares_Jobs_intJobId",
                        column: x => x.intJobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_intJobId",
                table: "Hardwares",
                column: "intJobId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_intCustomerId",
                table: "Jobs",
                column: "intCustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hardwares");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
