using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LoginTokenTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId_Value",
                table: "LoginTokens",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "LoginTokens",
                newName: "UserId_Value");
        }
    }
}
