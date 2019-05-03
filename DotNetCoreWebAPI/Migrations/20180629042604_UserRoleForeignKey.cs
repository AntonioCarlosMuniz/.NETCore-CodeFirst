using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreWebAPI.Migrations
{
    public partial class UserRoleForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
               name: "FK_UserRole_Role_RoleId",
               table: "UserRole",
               column: "RoleId",
               principalTable: "Role",
               principalColumn: "Id",
               onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
               name: "FK_UserRole_Role_RoleId",
                table: "UserRole");
        }
    }
}
