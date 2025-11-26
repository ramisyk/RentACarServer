using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserForgotPasswordUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ForgotPasswordId_Value",
                table: "Users",
                newName: "ForgotPasswordCode_Value");

            migrationBuilder.AlterColumn<bool>(
                name: "IsForgotPasswordCompleted_Value",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ForgotPasswordCode_Value",
                table: "Users",
                newName: "ForgotPasswordId_Value");

            migrationBuilder.AlterColumn<bool>(
                name: "IsForgotPasswordCompleted_Value",
                table: "Users",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
