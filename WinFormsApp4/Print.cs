using funcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Print : DraggablePanel
    {
        string emp_id = " ";
        float result = 0;
        public Print(string cur_employee_n_id)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            this.emp_id = cur_employee_n_id;
        }


        private void Print_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AppDbContext db = AppDbContext.Instance;
            var res = db.in_students.Where(st => st.student_n_id == textBox1.Text).FirstOrDefault();
            if (res != null)
            {
                res.paper_printed = int.Parse(Num_pg_tb.Text);
                db.in_students.Update(res);
                db.SaveChanges();
            }

            else if(ValidationMethods.NationalIdLen(textBox1.Text))
            {
                db.history.Add(new HistoryTable
                {
                    student_n_id = "1",
                    time_in = DateTime.Now.ToString("HH:mm"),
                    time_out = DateTime.Now.ToString("HH:mm"),
                    date = DateTime.Now.ToString("dd/MM/yyyy"),
                    employee_n_id = emp_id,
                    paper_count = int.Parse(Num_pg_tb.Text),
                    cost = (int.Parse(Num_pg_tb.Text) * SharedValues.CostPerPaper)
                });
                db.SaveChanges();

            }
            else
            {
                MessageBox.Show("Invalid ID", " Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Cost Added", " Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.Count > 0)
                Application.OpenForms[0].Show();
            this.Close();
        }

        private void Num_pg_tb_TextChanged(object sender, EventArgs e)
        {
            // Perform the calculation when the text in TextBox1 changes
            if (int.TryParse(Num_pg_tb.Text, out int inputValue))
            {

                float result = inputValue * SharedValues.CostPerPaper;
                tt_cost.Text = result.ToString();

            }
            else
            {
                tt_cost.Text = "Invalid input";
            }
        }
    }
}
