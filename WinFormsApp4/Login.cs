using System.Collections.Specialized;
using WinFormsApp4.data;
using WinFormsApp4;


namespace WinFormsApp4
{
    public partial class Login_Page : DraggablePanel
    {


        public Login_Page()
        {

            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_up_form frm2 = new Sign_up_form();
            frm2.ShowDialog();
            //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
            string user_name_in = textBox1.Text;
            string password_in = textBox2.Text;
            if (!string.IsNullOrWhiteSpace(user_name_in) &&
                !string.IsNullOrWhiteSpace(password_in))
            {
                var emp = db.employees.
                   Where(a => (a.user_name == user_name_in || a.email == user_name_in) && a.password == password_in).FirstOrDefault();
                if (emp != null)
                {
                    MessageBox.Show("Welcome " + emp.name);
                    program_main_form frm = new program_main_form(emp.employee_n_id);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("please enter user name and password");
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (db.Database.EnsureCreated())
            {
                MessageBox.Show("connection doen");
            }
            else
            {
                MessageBox.Show("connection is already done");
            }
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget_pas forget = new forget_pas();
            forget.ShowDialog();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else { textBox2.UseSystemPasswordChar = true; }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}