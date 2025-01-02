using funcs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp4.data;
using System.Drawing.Text;

namespace WinFormsApp4
{


    // branch
    public partial class program_main_form : DraggablePanel
    {


        string txt = "null";
        string cur_user_name;
        string cur_employee_n_id;

        public program_main_form(string employee_n_id)
        {
            InitializeComponent();
            this.cur_employee_n_id = employee_n_id;

        }

        private void Log_out_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "LOG OUT",
                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                this.Close();
                Application.OpenForms[0].Show();
            }
        }

        private void PreviewImageAndName()
        {
            try
            {
                name_label_text = db.employees
                 .Where((x) => x.employee_n_id == cur_employee_n_id).FirstOrDefault().name;
                cur_user_name = name_label_text = db.employees
                    .Where((x) => x.employee_n_id == cur_employee_n_id).FirstOrDefault().user_name;
                txt = name_label_text;
                textBox1.Text = txt;
                string photo_path_to_show = db.employees
                    .Where((x) => x.employee_n_id == cur_employee_n_id).FirstOrDefault().photo_path;
                pictureBox1.ImageLocation = photo_path_to_show;
            }
            catch (Exception ex)
            {

                this.Close();
                Application.OpenForms[0].Show();


            }
        }

        private void program_main_form_Load(object sender, EventArgs e)
        {

            Reg_newstudbtn.Hide();
            PreviewImageAndName();
            UpdateGridView();
        }


        private void FindSTU_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT IMPLEMENTED YET", "Sorry",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StudentOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT IMPLEMENTED YET", "Sorry",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }


        private void AddStudBtn(object sender, EventArgs e)
        {

            ValidationMethods.StudentCheckIn(StudNational_txtbox.Text);
            Reg_newstudbtn.Show();
            UpdateGridView();
        }


        private void Reg_newstudbtn_Click(object sender, EventArgs e)
        {
            New_stu_reg frm = new New_stu_reg();
            frm.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // Ask the user for confirmation using a message box
            DialogResult result = MessageBox.Show("Are you sure you want to remove?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {

                ValidationMethods.StudentCheckOut(StudNational_txtbox.Text, this.cur_employee_n_id);
                UpdateGridView();

            }


        }
        private void UpdateGridView()
        {
            this.dataGridView2.Rows.Clear();
            // dataGridView2.Rows.CollectionChanged();
            var InView = DataBaseMethods.getInView();
            foreach (var element in InView)
            {
                this.dataGridView2.Rows.Add(element[0], element[1], element[2], element[3], element[4]);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = Prompt.ShowDialog("Enter Password", "Confirmation Dialog", true);
            var emp1 = DataBaseMethods.GetEmlpyeeByID(cur_employee_n_id);
            if (emp1.password.Equals(input))
            {
                Form ac = new Account(cur_employee_n_id);
                ac.ShowDialog();
                PreviewImageAndName();
            }
            else
            {
                MessageBox.Show("Wrong Password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Configure configure = new Configure();
            configure.ShowDialog();

        }

        // -------------------- Empty Functions --------------------

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudNational_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /* private void button2_Click(object sender, EventArgs e)
         {
             Print ppt = new Print();

             ppt.ShowDialog();
         }
        */
        private void History_btn_Click(object sender, EventArgs e)
        {
            HistoryForm frm = new HistoryForm();
            frm.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Print print = new Print(this.cur_employee_n_id);
            print.ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

