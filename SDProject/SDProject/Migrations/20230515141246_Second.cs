using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDProject.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IfMale",
                table: "Cases");

            migrationBuilder.AddColumn<int>(
                name: "CaseGender",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SignUpAdmins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignUpAdmins", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignUpAdmins");

            migrationBuilder.DropColumn(
                name: "CaseGender",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Admins");

            migrationBuilder.AddColumn<bool>(
                name: "IfMale",
                table: "Cases",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
