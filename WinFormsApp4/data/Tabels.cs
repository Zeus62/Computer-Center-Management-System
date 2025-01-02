using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace WinFormsApp4.data
{
  [Table("employee")]
  public record EmployeeTable
  {
    [Key]
    [Column(TypeName = "varchar(15)")]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string employee_n_id { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string name { get; set; }
    [Column(TypeName = "char(11)")]
    public string phone_number { get; set; }
    [Column(TypeName = "varchar(30)")]
    public string email { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string user_name { get; set; }
    public string photo_path {get; set;}
    [Column(TypeName = "varchar(20)")]
    public string password { get; set; }
  }
  [Table("students")]
  public record StudentsTable
  {
    [Key]
    [Column(TypeName = "varchar(15)")]
    public string student_n_id { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string name { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string faculty { get; set; }
    public int level { get; set; }
  }
    [Table("in_students")]
    public record InStudentsTable
    {
        public InStudentsTable()
        {
            paper_printed=0;
        }

       [Key]
    [Column(TypeName = "varchar(15)")]
    [ForeignKey("StudentsTable")]
    public string student_n_id { get; set; }
    [Column(TypeName = "char(5)")]
    public string in_time { get; set; }
    public int paper_printed { get; set; }
  }
  [Table("history")]
  public record HistoryTable
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int history_id { get; set; }
    [Column(TypeName = "char(15)")]
    [ForeignKey("EmployeeTable")]
    public string employee_n_id { get; set; }
    [Column(TypeName = "char(15)")]
    [ForeignKey("StudentsTable")]
    public string student_n_id { get; set; }
    [Column(TypeName = "char(5)")]
    public string time_in { get; set; }
    [Column(TypeName = "char(5)")]
    public string time_out { get; set; }
    [Column(TypeName = "char(10)")]
    public string date { get; set; }
    public double cost { get; set; }
    public int paper_count { get; set; }
  }
  internal partial class AppDbContext : DbContext
  {
    public DbSet<EmployeeTable> employees { get; set; }
    public DbSet<StudentsTable> students { get; set; }
    public DbSet<InStudentsTable> in_students { get; set; }
    public DbSet<HistoryTable> history { get; set; }
  }
}


