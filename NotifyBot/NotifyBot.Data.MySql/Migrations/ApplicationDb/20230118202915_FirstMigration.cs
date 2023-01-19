using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotifyBot.Data.MySql.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "alert_configuration",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false),
                    alerttype = table.Column<int>(name: "alert_type", type: "int", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_alert_configuration", x => x.id);
                    table.ForeignKey(
                        name: "fk_alert_configuration_user_user_id",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "alert_configuration_platform",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    alertconfigurationid = table.Column<int>(name: "alert_configuration_id", type: "int", nullable: false),
                    alertplatform = table.Column<int>(name: "alert_platform", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_alert_configuration_platform", x => x.id);
                    table.ForeignKey(
                        name: "fk_alert_configuration_platform_alert_configuration_alert_confi",
                        column: x => x.alertconfigurationid,
                        principalTable: "alert_configuration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_alert_configuration_user_id",
                table: "alert_configuration",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_alert_configuration_platform_alert_configuration_id",
                table: "alert_configuration_platform",
                column: "alert_configuration_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_name",
                table: "user",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alert_configuration_platform");

            migrationBuilder.DropTable(
                name: "alert_configuration");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
