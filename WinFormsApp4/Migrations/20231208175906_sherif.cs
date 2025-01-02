using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp4.Migrations
{
    public partial class sherif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "students",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "faculty",
                table: "students",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "in_time",
                table: "in_students",
                type: "char(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)");

            migrationBuilder.AlterColumn<string>(
                name: "time_out",
                table: "history",
                type: "char(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)");

            migrationBuilder.AlterColumn<string>(
                name: "time_in",
                table: "history",
                type: "char(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)");

            migrationBuilder.AlterColumn<string>(
                name: "student_n_id",
                table: "history",
                type: "char(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(15)");

            migrationBuilder.AlterColumn<string>(
                name: "employee_n_id",
                table: "history",
                type: "char(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(15)");

            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "history",
                type: "char(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(10)");

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "employee",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "photo_path",
                table: "employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "employee",
                type: "char(11)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(11)");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "employee",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "employee",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "employee",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "students",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "faculty",
                table: "students",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "in_time",
                table: "in_students",
                type: "char(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "time_out",
                table: "history",
                type: "char(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "time_in",
                table: "history",
                type: "char(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "student_n_id",
                table: "history",
                type: "char(15)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "employee_n_id",
                table: "history",
                type: "char(15)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "history",
                type: "char(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "employee",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "photo_path",
                table: "employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "employee",
                type: "char(11)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(11)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "employee",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "employee",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "employee",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);
        }
    }
}
