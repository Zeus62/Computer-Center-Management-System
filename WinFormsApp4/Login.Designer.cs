using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class Login_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        AppDbContext db = AppDbContext.Instance;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            button5=new Button();
            button3=new Button();
            button4=new Button();
            pictureBox2=new PictureBox();
            panel3=new Panel();
            panel4=new Panel();
            checkBox1=new CheckBox();
            pictureBox1=new PictureBox();
            linkLabel1=new LinkLabel();
            textBox1=new TextBox();
            label1=new Label();
            linkLabel2=new LinkLabel();
            label8=new Label();
            button1=new Button();
            label6=new Label();
            textBox2=new TextBox();
            panel2=new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            button5.AutoSize=true;
            button5.BackColor=Color.SeaGreen;
            button5.FlatStyle=FlatStyle.Popup;
            button5.ForeColor=SystemColors.ControlDarkDark;
            button5.Image=(Image)resources.GetObject("button5.Image");
            button5.Location=new Point(629, 3);
            button5.Name="button5";
            button5.Size=new Size(36, 36);
            button5.TabIndex=31;
            button5.UseVisualStyleBackColor=false;
            button5.Click+=button5_Click;
            // 
            // button3
            // 
            button3.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            button3.AutoSize=true;
            button3.BackColor=Color.SeaGreen;
            button3.FlatStyle=FlatStyle.Popup;
            button3.ForeColor=SystemColors.ButtonHighlight;
            button3.Image=Properties.Resources.icons8_minus_24;
            button3.Location=new Point(587, 3);
            button3.Name="button3";
            button3.Size=new Size(36, 36);
            button3.TabIndex=30;
            button3.UseVisualStyleBackColor=false;
            button3.Click+=button3_Click;
            // 
            // button4
            // 
            button4.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            button4.AutoSize=true;
            button4.BackColor=Color.SeaGreen;
            button4.FlatStyle=FlatStyle.Popup;
            button4.ForeColor=SystemColors.ControlDarkDark;
            button4.Image=(Image)resources.GetObject("button4.Image");
            button4.Location=new Point(675, 3);
            button4.Name="button4";
            button4.Size=new Size(36, 36);
            button4.TabIndex=32;
            button4.UseVisualStyleBackColor=false;
            button4.Click+=button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor=AnchorStyles.None;
            pictureBox2.Image=Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location=new Point(3, 151);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(218, 187);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=33;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.Anchor=AnchorStyles.None;
            panel3.Controls.Add(pictureBox2);
            panel3.Location=new Point(0, 0);
            panel3.Name="panel3";
            panel3.Size=new Size(221, 501);
            panel3.TabIndex=35;
            // 
            // panel4
            // 
            panel4.Anchor=AnchorStyles.None;
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(linkLabel1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(linkLabel2);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBox2);
            panel4.Location=new Point(0, 48);
            panel4.Name="panel4";
            panel4.Size=new Size(546, 453);
            panel4.TabIndex=0;
            panel4.Paint+=panel4_Paint_1;
            // 
            // checkBox1
            // 
            checkBox1.Anchor=AnchorStyles.None;
            checkBox1.AutoSize=true;
            checkBox1.Font=new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location=new Point(262, 294);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(126, 23);
            checkBox1.TabIndex=3;
            checkBox1.Text="Show Password";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor=AnchorStyles.None;
            pictureBox1.BackColor=Color.SeaGreen;
            pictureBox1.Image=Properties.Resources.icons8_person_642;
            pictureBox1.Location=new Point(310, 49);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(132, 119);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=24;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor=AnchorStyles.None;
            linkLabel1.AutoSize=true;
            linkLabel1.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor=Color.SeaGreen;
            linkLabel1.Location=new Point(329, 398);
            linkLabel1.Name="linkLabel1";
            linkLabel1.Size=new Size(91, 23);
            linkLabel1.TabIndex=6;
            linkLabel1.TabStop=true;
            linkLabel1.Text="New User?";
            linkLabel1.LinkClicked+=linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Anchor=AnchorStyles.None;
            textBox1.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor=SystemColors.ActiveCaptionText;
            textBox1.Location=new Point(262, 199);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(242, 27);
            textBox1.TabIndex=0;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.None;
            label1.AutoSize=true;
            label1.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(262, 244);
            label1.Name="label1";
            label1.Size=new Size(93, 21);
            label1.TabIndex=22;
            label1.Text="Password";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor=AnchorStyles.None;
            linkLabel2.AutoSize=true;
            linkLabel2.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor=Color.SeaGreen;
            linkLabel2.Location=new Point(310, 375);
            linkLabel2.Name="linkLabel2";
            linkLabel2.Size=new Size(143, 23);
            linkLabel2.TabIndex=5;
            linkLabel2.TabStop=true;
            linkLabel2.Text="Forgot Password?";
            linkLabel2.LinkClicked+=linkLabel2_LinkClicked;
            // 
            // label8
            // 
            label8.Anchor=AnchorStyles.None;
            label8.AutoSize=true;
            label8.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor=Color.FromArgb(64, 64, 64);
            label8.Location=new Point(245, 0);
            label8.Name="label8";
            label8.Size=new Size(279, 37);
            label8.TabIndex=21;
            label8.Text="Login to Your Account";
            label8.Click+=label8_Click;
            // 
            // button1
            // 
            button1.Anchor=AnchorStyles.None;
            button1.BackColor=Color.SeaGreen;
            button1.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.ButtonHighlight;
            button1.Location=new Point(262, 329);
            button1.Name="button1";
            button1.Size=new Size(242, 43);
            button1.TabIndex=4;
            button1.Text="Login";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // label6
            // 
            label6.Anchor=AnchorStyles.None;
            label6.AutoSize=true;
            label6.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor=Color.SeaGreen;
            label6.Location=new Point(262, 180);
            label6.Name="label6";
            label6.Size=new Size(177, 21);
            label6.TabIndex=23;
            label6.Text="User Name or Email";
            // 
            // textBox2
            // 
            textBox2.Anchor=AnchorStyles.None;
            textBox2.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location=new Point(262, 263);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(242, 27);
            textBox2.TabIndex=1;
            textBox2.TextChanged+=textBox2_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor=AnchorStyles.None;
            panel2.Controls.Add(panel4);
            panel2.Location=new Point(0, 0);
            panel2.Name="panel2";
            panel2.Size=new Size(546, 501);
            panel2.TabIndex=34;
            panel2.Paint+=panel2_Paint_2;
            // 
            // Login_Page
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(729, 501);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Login_Page";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Log in";
            Load+=Login_Page_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private Label label1;
        private LinkLabel linkLabel2;
        private Label label8;
        private Button button1;
        private Label label6;
        private TextBox textBox2;
        private Panel panel2;
    }
}