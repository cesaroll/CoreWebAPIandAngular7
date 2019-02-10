using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbSet",
                table: "DbSet");

            migrationBuilder.RenameTable(
                name: "DbSet",
                newName: "PaymentDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails",
                column: "PMId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails");

            migrationBuilder.RenameTable(
                name: "PaymentDetails",
                newName: "DbSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbSet",
                table: "DbSet",
                column: "PMId");
        }
    }
}
