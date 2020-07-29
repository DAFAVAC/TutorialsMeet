using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorialsMeet.Migrations
{
    public partial class Creacion_Reuniones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reuniones",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_registro = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Tema = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Chat = table.Column<string>(nullable: true),
                    Hora_Inicio = table.Column<DateTime>(nullable: false),
                    Hora_Finaliza = table.Column<DateTime>(nullable: false),
                    Estudiantesid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reuniones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reuniones_Estudiantes_Estudiantesid",
                        column: x => x.Estudiantesid,
                        principalTable: "Estudiantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reuniones_Estudiantesid",
                table: "Reuniones",
                column: "Estudiantesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reuniones");
        }
    }
}
