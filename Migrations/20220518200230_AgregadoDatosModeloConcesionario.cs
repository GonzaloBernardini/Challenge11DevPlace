using Microsoft.EntityFrameworkCore.Migrations;

namespace ConcesionarioChallenge11.Migrations
{
    public partial class AgregadoDatosModeloConcesionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Unidades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Concesionario",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Concesionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Concesionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "Concesionario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Concesionario");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Concesionario");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Concesionario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Unidades",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Concesionario",
                newName: "id");

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    IdLogin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.IdLogin);
                });
        }
    }
}
