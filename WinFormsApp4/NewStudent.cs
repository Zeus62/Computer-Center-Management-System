using funcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.data;

namespace WinFormsApp4
{
    public partial class New_stu_reg : DraggablePanel
    {
        public New_stu_reg()
        {
            //new DraggablePanel(this);
            InitializeComponent();
        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void N_id_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Faculty_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Level_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_newstudbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(name_txtbox.Text))
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationMethods.NationalIdLen(N_id_txtbox.Text))
            {
                MessageBox.Show("National ID must be 14 digits", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidationMethods.IsStudent(N_id_txtbox.Text))
            {
                MessageBox.Show("Wrong National Id", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(Level_txtbox.Text, "^(1|2|3|4|5)$"))
            {
                MessageBox.Show("Invalid Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            StudentsTable student = new StudentsTable()
            {
                name = name_txtbox.Text,
                student_n_id = N_id_txtbox.Text,
                faculty = Faculty_txtbox.Text,
                level = Convert.ToInt32(Level_txtbox.Text)
            };
            DataBaseMethods.AddStudent(student);
            // MessageBox.Show("Student Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            this.Close();

        }


        private void button3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_stu_reg_Load(object sender, EventArgs e)
        {

        }
    }
}
