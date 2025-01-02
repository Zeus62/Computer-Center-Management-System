namespace WinFormsApp4
{
    partial class Account
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            button2=new Button();
            openFileDialog1=new OpenFileDialog();
            label8=new Label();
            pictureBox2=new PictureBox();
            pictureBox3=new PictureBox();
            panel1=new Panel();
            button5=new Button();
            pictureBox1=new PictureBox();
            openFileDialog2=new OpenFileDialog();
            button6=new Button();
            label7=new Label();
            user_txtbox=new TextBox();
            label6=new Label();
            National_id_txtbox=new TextBox();
            label5=new Label();
            cpass_txtbox=new TextBox();
            label4=new Label();
            email_txtbox=new TextBox();
            label3=new Label();
            password_txtbox=new TextBox();
            label2=new Label();
            phone_num_txtbox=new TextBox();
            label1=new Label();
            name_txtbox=new TextBox();
            button7=new Button();
            panel2=new Panel();
            button1=new Button();
            button8=new Button();
            checkBox1=new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location=new Point(0, 0);
            button2.Margin=new Padding(3, 4, 3, 4);
            button2.Name="button2";
            button2.Size=new Size(86, 31);
            button2.TabIndex=47;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor=Color.SeaGreen;
            label8.Location=new Point(331, 89);
            label8.Name="label8";
            label8.Size=new Size(130, 41);
            label8.TabIndex=42;
            label8.Text="Sign Up";
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location=new Point(27, 52);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(126, 116);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=19;
            pictureBox2.TabStop=false;
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
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock=DockStyle.Left;
            panel1.Location=new Point(0, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(304, 701);
            panel1.TabIndex=41;
            // 
            // button5
            // 
            button5.BackColor=Color.SeaGreen;
            button5.FlatStyle=FlatStyle.Popup;
            button5.Font=new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor=SystemColors.ButtonHighlight;
            button5.Location=new Point(86, 243);
            button5.Margin=new Padding(3, 4, 3, 4);
            button5.Name="button5";
            button5.Size=new Size(112, 28);
            button5.TabIndex=18;
            button5.Text="Select Photo";
            button5.UseVisualStyleBackColor=false;
            button5.Click+=button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=Color.SeaGreen;
            pictureBox1.Image=Properties.Resources.icons8_person_641;
            pictureBox1.Location=new Point(73, 52);
            pictureBox1.Margin=new Padding(0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(143, 171);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=17;
            pictureBox1.TabStop=false;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName="openFileDialog1";
            // 
            // button6
            // 
            button6.BackColor=Color.SeaGreen;
            button6.FlatStyle=FlatStyle.Popup;
            button6.ForeColor=SystemColors.ControlDarkDark;
            button6.Image=(Image)resources.GetObject("button6.Image");
            button6.Location=new Point(71, 4);
            button6.Margin=new Padding(3, 4, 3, 4);
            button6.Name="button6";
            button6.Size=new Size(39, 40);
            button6.TabIndex=27;
            button6.UseVisualStyleBackColor=false;
            button6.Click+=button6_Click;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor=Color.SeaGreen;
            label7.Location=new Point(335, 360);
            label7.Name="label7";
            label7.Size=new Size(137, 21);
            label7.TabIndex=40;
            label7.Text="Phone Number";
            // 
            // user_txtbox
            // 
            user_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            user_txtbox.Location=new Point(617, 191);
            user_txtbox.Margin=new Padding(3, 4, 3, 4);
            user_txtbox.Name="user_txtbox";
            user_txtbox.Size=new Size(207, 27);
            user_txtbox.TabIndex=39;
            user_txtbox.TextAlign=HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor=Color.SeaGreen;
            label6.Location=new Point(617, 161);
            label6.Name="label6";
            label6.Size=new Size(103, 21);
            label6.TabIndex=38;
            label6.Text="User Name";
            // 
            // National_id_txtbox
            // 
            National_id_txtbox.Enabled=false;
            National_id_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            National_id_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            National_id_txtbox.Location=new Point(335, 284);
            National_id_txtbox.Margin=new Padding(3, 4, 3, 4);
            National_id_txtbox.Name="National_id_txtbox";
            National_id_txtbox.Size=new Size(215, 27);
            National_id_txtbox.TabIndex=37;
            National_id_txtbox.TextAlign=HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor=Color.SeaGreen;
            label5.Location=new Point(617, 360);
            label5.Name="label5";
            label5.Size=new Size(209, 21);
            label5.TabIndex=36;
            label5.Text="Confirm New Password";
            // 
            // cpass_txtbox
            // 
            cpass_txtbox.AllowDrop=true;
            cpass_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cpass_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            cpass_txtbox.Location=new Point(617, 385);
            cpass_txtbox.Margin=new Padding(3, 4, 3, 4);
            cpass_txtbox.Name="cpass_txtbox";
            cpass_txtbox.Size=new Size(207, 27);
            cpass_txtbox.TabIndex=35;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor=Color.SeaGreen;
            label4.Location=new Point(335, 259);
            label4.Name="label4";
            label4.Size=new Size(103, 21);
            label4.TabIndex=34;
            label4.Text="National id";
            // 
            // email_txtbox
            // 
            email_txtbox.Enabled=false;
            email_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            email_txtbox.Location=new Point(335, 477);
            email_txtbox.Margin=new Padding(3, 4, 3, 4);
            email_txtbox.Name="email_txtbox";
            email_txtbox.Size=new Size(490, 27);
            email_txtbox.TabIndex=33;
            email_txtbox.TextAlign=HorizontalAlignment.Center;
            email_txtbox.TextChanged+=email_txtbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.SeaGreen;
            label3.Location=new Point(338, 452);
            label3.Name="label3";
            label3.Size=new Size(56, 21);
            label3.TabIndex=32;
            label3.Text="Email";
            // 
            // password_txtbox
            // 
            password_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            password_txtbox.Location=new Point(617, 284);
            password_txtbox.Margin=new Padding(3, 4, 3, 4);
            password_txtbox.Name="password_txtbox";
            password_txtbox.Size=new Size(207, 27);
            password_txtbox.TabIndex=31;
            password_txtbox.TextChanged+=password_txtbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.SeaGreen;
            label2.Location=new Point(617, 259);
            label2.Name="label2";
            label2.Size=new Size(136, 21);
            label2.TabIndex=30;
            label2.Text="New Password";
            label2.Click+=label2_Click;
            // 
            // phone_num_txtbox
            // 
            phone_num_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phone_num_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            phone_num_txtbox.Location=new Point(335, 385);
            phone_num_txtbox.Margin=new Padding(3, 4, 3, 4);
            phone_num_txtbox.Name="phone_num_txtbox";
            phone_num_txtbox.Size=new Size(215, 27);
            phone_num_txtbox.TabIndex=29;
            phone_num_txtbox.TextAlign=HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(335, 161);
            label1.Name="label1";
            label1.Size=new Size(59, 21);
            label1.TabIndex=28;
            label1.Text="Name";
            // 
            // name_txtbox
            // 
            name_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_txtbox.ForeColor=SystemColors.ActiveCaptionText;
            name_txtbox.Location=new Point(335, 191);
            name_txtbox.Margin=new Padding(3, 4, 3, 4);
            name_txtbox.Name="name_txtbox";
            name_txtbox.Size=new Size(215, 27);
            name_txtbox.TabIndex=27;
            name_txtbox.TextAlign=HorizontalAlignment.Center;
            // 
            // button7
            // 
            button7.BackColor=Color.SeaGreen;
            button7.FlatStyle=FlatStyle.Popup;
            button7.Font=new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor=SystemColors.Control;
            button7.Location=new Point(311, 617);
            button7.Margin=new Padding(3, 4, 3, 4);
            button7.Name="button7";
            button7.Size=new Size(165, 47);
            button7.TabIndex=26;
            button7.Text="Save Changes";
            button7.UseVisualStyleBackColor=false;
            button7.Click+=button7_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button6);
            panel2.Dock=DockStyle.Right;
            panel2.Location=new Point(777, 0);
            panel2.Margin=new Padding(3, 4, 3, 4);
            panel2.Name="panel2";
            panel2.Size=new Size(178, 701);
            panel2.TabIndex=43;
            // 
            // button1
            // 
            button1.BackColor=Color.FromArgb(192, 0, 0);
            button1.FlatStyle=FlatStyle.Popup;
            button1.Font=new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.Control;
            button1.Location=new Point(503, 617);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Size=new Size(165, 47);
            button1.TabIndex=45;
            button1.Text="Delete Acount";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // button8
            // 
            button8.BackColor=Color.FromArgb(255, 128, 0);
            button8.FlatStyle=FlatStyle.Popup;
            button8.Font=new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor=SystemColors.Control;
            button8.Location=new Point(691, 617);
            button8.Margin=new Padding(3, 4, 3, 4);
            button8.Name="button8";
            button8.Size=new Size(165, 47);
            button8.TabIndex=46;
            button8.Text="Discard changes";
            button8.UseVisualStyleBackColor=false;
            button8.Click+=button8_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Font=new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location=new Point(617, 420);
            checkBox1.Margin=new Padding(3, 4, 3, 4);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(126, 23);
            checkBox1.TabIndex=48;
            checkBox1.Text="Show Password";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // Account
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(955, 701);
            Controls.Add(checkBox1);
            Controls.Add(button8);
            Controls.Add(button1);
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
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(button2);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3, 4, 3, 4);
            MaximizeBox=false;
            MinimizeBox=false;
            Name="Account";
            Text="Account";
            Load+=Account_Load;
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(button7, 0);
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
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button8, 0);
            Controls.SetChildIndex(checkBox1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button button5;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog2;
        private Button button6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button7;
        private Panel panel2;
        // --------------
        private TextBox National_id_txtbox;
        private TextBox cpass_txtbox;
        private TextBox email_txtbox;
        private TextBox password_txtbox;
        private TextBox phone_num_txtbox;
        private TextBox name_txtbox;
        private TextBox user_txtbox;
        private Button button1;
        private Button button8;
        private CheckBox checkBox1;
    }
}