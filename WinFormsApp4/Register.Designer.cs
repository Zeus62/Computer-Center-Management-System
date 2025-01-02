using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class Sign_up_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        AppDbContext db = AppDbContext.Instance;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up_form));
            label1=new Label();
            name_txtbox=new TextBox();
            label2=new Label();
            phone_num_txtbox=new TextBox();
            label3=new Label();
            password_txtbox=new TextBox();
            label4=new Label();
            email_txtbox=new TextBox();
            label5=new Label();
            cpass_txtbox=new TextBox();
            label6=new Label();
            National_id_txtbox=new TextBox();
            label7=new Label();
            user_txtbox=new TextBox();
            pictureBox1=new PictureBox();
            openFileDialog1=new OpenFileDialog();
            button2=new Button();
            button1=new Button();
            panel1=new Panel();
            pictureBox3=new PictureBox();
            pictureBox2=new PictureBox();
            label8=new Label();
            checkBox1=new CheckBox();
            checkBox2=new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(335, 167);
            label1.Name="label1";
            label1.Size=new Size(59, 21);
            label1.TabIndex=4;
            label1.Text="Name";
            // 
            // name_txtbox
            // 
            name_txtbox.Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            name_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            name_txtbox.Location=new Point(335, 196);
            name_txtbox.Margin=new Padding(3, 4, 3, 4);
            name_txtbox.Name="name_txtbox";
            name_txtbox.Size=new Size(215, 26);
            name_txtbox.TabIndex=1;
            name_txtbox.TextChanged+=textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.SeaGreen;
            label2.Location=new Point(623, 264);
            label2.Name="label2";
            label2.Size=new Size(93, 21);
            label2.TabIndex=6;
            label2.Text="Password";
            // 
            // phone_num_txtbox
            // 
            phone_num_txtbox.Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phone_num_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            phone_num_txtbox.Location=new Point(335, 391);
            phone_num_txtbox.Margin=new Padding(3, 4, 3, 4);
            phone_num_txtbox.Name="phone_num_txtbox";
            phone_num_txtbox.Size=new Size(215, 26);
            phone_num_txtbox.TabIndex=3;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.SeaGreen;
            label3.Location=new Point(338, 457);
            label3.Name="label3";
            label3.Size=new Size(56, 21);
            label3.TabIndex=8;
            label3.Text="Email";
            // 
            // password_txtbox
            // 
            password_txtbox.Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            password_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            password_txtbox.Location=new Point(617, 289);
            password_txtbox.Margin=new Padding(3, 4, 3, 4);
            password_txtbox.Name="password_txtbox";
            password_txtbox.Size=new Size(207, 26);
            password_txtbox.TabIndex=6;
            password_txtbox.TextChanged+=password_txtbox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor=Color.SeaGreen;
            label4.Location=new Point(335, 264);
            label4.Name="label4";
            label4.Size=new Size(103, 21);
            label4.TabIndex=10;
            label4.Text="National id";
            // 
            // email_txtbox
            // 
            email_txtbox.Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            email_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            email_txtbox.Location=new Point(335, 483);
            email_txtbox.Margin=new Padding(3, 4, 3, 4);
            email_txtbox.Name="email_txtbox";
            email_txtbox.Size=new Size(219, 26);
            email_txtbox.TabIndex=4;
            email_txtbox.TextChanged+=email_txtbox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor=Color.SeaGreen;
            label5.Location=new Point(617, 365);
            label5.Name="label5";
            label5.Size=new Size(172, 21);
            label5.TabIndex=12;
            label5.Text="Re-Enter Password";
            // 
            // cpass_txtbox
            // 
            cpass_txtbox.Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cpass_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            cpass_txtbox.Location=new Point(617, 391);
            cpass_txtbox.Margin=new Padding(3, 4, 3, 4);
            cpass_txtbox.Name="cpass_txtbox";
            cpass_txtbox.Size=new Size(207, 26);
            cpass_txtbox.TabIndex=7;
            cpass_txtbox.TextChanged+=cpass_txtbox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor=Color.SeaGreen;
            label6.Location=new Point(617, 167);
            label6.Name="label6";
            label6.Size=new Size(103, 21);
            label6.TabIndex=14;
            label6.Text="User Name";
            // 
            // National_id_txtbox
            // 
            National_id_txtbox.Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            National_id_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            National_id_txtbox.Location=new Point(335, 289);
            National_id_txtbox.Margin=new Padding(3, 4, 3, 4);
            National_id_txtbox.Name="National_id_txtbox";
            National_id_txtbox.Size=new Size(215, 26);
            National_id_txtbox.TabIndex=2;
            National_id_txtbox.TextChanged+=National_id_txtbox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor=Color.SeaGreen;
            label7.Location=new Point(335, 365);
            label7.Name="label7";
            label7.Size=new Size(137, 21);
            label7.TabIndex=16;
            label7.Text="Phone Number";
            // 
            // user_txtbox
            // 
            user_txtbox.Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            user_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            user_txtbox.Location=new Point(617, 196);
            user_txtbox.Margin=new Padding(3, 4, 3, 4);
            user_txtbox.Name="user_txtbox";
            user_txtbox.Size=new Size(207, 26);
            user_txtbox.TabIndex=5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=Color.SeaGreen;
            pictureBox1.Image=Properties.Resources.icons8_person_641;
            pictureBox1.Location=new Point(72, 55);
            pictureBox1.Margin=new Padding(0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(143, 171);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=17;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            openFileDialog1.FileOk+=openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.BackColor=Color.SeaGreen;
            button2.FlatStyle=FlatStyle.Popup;
            button2.Font=new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor=SystemColors.ButtonHighlight;
            button2.Location=new Point(85, 245);
            button2.Margin=new Padding(3, 4, 3, 4);
            button2.Name="button2";
            button2.Size=new Size(112, 28);
            button2.TabIndex=18;
            button2.Text="Select Photo";
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor=Color.SeaGreen;
            button1.FlatStyle=FlatStyle.Popup;
            button1.Font=new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.ButtonHighlight;
            button1.Location=new Point(472, 565);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Size=new Size(238, 47);
            button1.TabIndex=8;
            button1.Text="Regisiter";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location=new Point(0, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(304, 657);
            panel1.TabIndex=19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image=(Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location=new Point(-32, 264);
            pictureBox3.Margin=new Padding(3, 4, 3, 4);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(360, 400);
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex=21;
            pictureBox3.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location=new Point(801, 72);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(133, 116);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=19;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor=Color.SeaGreen;
            label8.Location=new Point(331, 95);
            label8.Name="label8";
            label8.Size=new Size(130, 41);
            label8.TabIndex=20;
            label8.Text="Sign Up";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Location=new Point(617, 488);
            checkBox1.Margin=new Padding(3, 4, 3, 4);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(226, 24);
            checkBox1.TabIndex=25;
            checkBox1.Text="I Agree Terms and Conditions";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize=true;
            checkBox2.Font=new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location=new Point(621, 323);
            checkBox2.Margin=new Padding(3, 4, 3, 4);
            checkBox2.Name="checkBox2";
            checkBox2.Size=new Size(126, 23);
            checkBox2.TabIndex=26;
            checkBox2.Text="Show Password";
            checkBox2.UseVisualStyleBackColor=true;
            checkBox2.CheckedChanged+=checkBox2_CheckedChanged;
            // 
            // Sign_up_form
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(933, 657);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(user_txtbox);
            Controls.Add(label6);
            Controls.Add(National_id_txtbox);
            Controls.Add(label5);
            Controls.Add(cpass_txtbox);
            Controls.Add(label4);
            Controls.Add(email_txtbox);
            Controls.Add(label3);
            Controls.Add(password_txtbox);
            Controls.Add(label2);
            Controls.Add(phone_num_txtbox);
            Controls.Add(label1);
            Controls.Add(name_txtbox);
            Controls.Add(button1);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3, 4, 3, 4);
            Name="Sign_up_form";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Sign up ";
            Load+=Sign_up_form_Load;
            KeyDown+=Sign_up_form_KeyDown;
            KeyPress+=Sign_up_form_KeyPress;
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(name_txtbox, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(phone_num_txtbox, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(password_txtbox, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(email_txtbox, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(cpass_txtbox, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(National_id_txtbox, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(user_txtbox, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(pictureBox2, 0);
            Controls.SetChildIndex(checkBox1, 0);
            Controls.SetChildIndex(checkBox2, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox name_txtbox;
        private Label label2;
        private TextBox phone_num_txtbox;
        private Label label3;
        private TextBox password_txtbox;
        private Label label4;
        private TextBox email_txtbox;
        private Label label5;
        private TextBox cpass_txtbox;
        private Label label6;
        private TextBox National_id_txtbox;
        private Label label7;
        private TextBox user_txtbox;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}