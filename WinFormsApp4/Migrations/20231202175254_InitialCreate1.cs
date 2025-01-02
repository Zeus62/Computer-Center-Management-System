using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp4.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    employee_n_id = table.Column<string>(type: "varchar(15)", nullable: false),
                    name = table.Column<string>(type: "varchar(20)", nullable: false),
                    phone_number = table.Column<string>(type: "char(11)", nullable: false),
                    email = table.Column<string>(type: "varchar(20)", nullable: false),
                    user_name = table.Column<string>(type: "varchar(10)", nullable: false),
                    photo_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.employee_n_id);
                });

            migrationBuilder.CreateTable(
                name: "history",
                columns: table => new
                {
                    history_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_n_id = table.Column<string>(type: "char(15)", nullable: false),
                    student_n_id = table.Column<string>(type: "char(15)", nullable: false),
                    time_in = table.Column<string>(type: "char(5)", nullable: false),
                    time_out = table.Column<string>(type: "char(5)", nullable: false),
                    date = table.Column<string>(type: "char(10)", nullable: false),
                    cost = table.Column<double>(type: "float", nullable: false),
                    paper_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_history", x => x.history_id);
                });

            migrationBuilder.CreateTable(
                name: "in_students",
                columns: table => new
                {
                    student_n_id = table.Column<string>(type: "varchar(15)", nullable: false),
                    in_time = table.Column<string>(type: "char(5)", nullable: false),
                    paper_printed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_in_students", x => x.student_n_id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    student_n_id = table.Column<string>(type: "varchar(15)", nullable: false),
                    name = table.Column<string>(type: "varchar(20)", nullable: false),
                    faculty = table.Column<string>(type: "varchar(20)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.student_n_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "history");

            migrationBuilder.DropTable(
                name: "in_students");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
