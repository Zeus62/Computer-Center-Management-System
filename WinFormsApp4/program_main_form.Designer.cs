using WinFormsApp4;
using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class program_main_form
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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program_main_form));
            History=new Button();
            Log_out_btn=new Button();
            emp_name=new Label();
            pictureBox1=new PictureBox();
            textBox1=new TextBox();
            panel1=new Panel();
            History_btn=new Button();
            button3=new Button();
            button2=new Button();
            button1=new Button();
            panel2=new Panel();
            panel6=new Panel();
            Reg_newstudbtn=new Button();
            button4=new Button();
            button5=new Button();
            label1=new Label();
            panel3=new Panel();
            panel7=new Panel();
            StudNational_txtbox=new TextBox();
            label2=new Label();
            dataGridView2=new DataGridView();
            IdSTU=new DataGridViewTextBoxColumn();
            NameSTU=new DataGridViewTextBoxColumn();
            FacultySTU=new DataGridViewTextBoxColumn();
            LevelSTU=new DataGridViewTextBoxColumn();
            In_timeSTU=new DataGridViewTextBoxColumn();
            panel5=new Panel();
            panel4=new Panel();
            button9=new Button();
            pictureBox2=new PictureBox();
            contextMenuStrip1=new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // History
            // 
            History.Location=new Point(0, 0);
            History.Margin=new Padding(3, 4, 3, 4);
            History.Name="History";
            History.Size=new Size(86, 31);
            History.TabIndex=8;
            // 
            // Log_out_btn
            // 
            Log_out_btn.BackColor=Color.FromArgb(64, 64, 64);
            Log_out_btn.FlatStyle=FlatStyle.Flat;
            Log_out_btn.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Log_out_btn.ForeColor=SystemColors.ButtonHighlight;
            Log_out_btn.Image=Properties.Resources.icons8_logout_24;
            Log_out_btn.ImageAlign=ContentAlignment.MiddleLeft;
            Log_out_btn.Location=new Point(14, 553);
            Log_out_btn.Margin=new Padding(3, 4, 3, 4);
            Log_out_btn.Name="Log_out_btn";
            Log_out_btn.Padding=new Padding(15, 0, 15, 0);
            Log_out_btn.Size=new Size(173, 48);
            Log_out_btn.TabIndex=0;
            Log_out_btn.Text="Log out";
            Log_out_btn.TextAlign=ContentAlignment.MiddleRight;
            Log_out_btn.UseVisualStyleBackColor=false;
            Log_out_btn.Click+=Log_out_btn_Click;
            // 
            // emp_name
            // 
            emp_name.AutoSize=true;
            emp_name.BackColor=Color.DarkSlateBlue;
            emp_name.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            emp_name.ForeColor=SystemColors.ButtonHighlight;
            emp_name.Location=new Point(25, 316);
            emp_name.Name="emp_name";
            emp_name.Size=new Size(0, 32);
            emp_name.TabIndex=4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new Point(0, 47);
            pictureBox1.Margin=new Padding(0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(80, 111);
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor=Color.SeaGreen;
            textBox1.BorderStyle=BorderStyle.None;
            textBox1.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor=SystemColors.Window;
            textBox1.Location=new Point(83, 92);
            textBox1.Margin=new Padding(3, 4, 3, 4);
            textBox1.Multiline=true;
            textBox1.Name="textBox1";
            textBox1.Size=new Size(128, 31);
            textBox1.TabIndex=1;
            textBox1.TextAlign=HorizontalAlignment.Center;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(History_btn);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Log_out_btn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(History);
            panel1.Dock=DockStyle.Left;
            panel1.Location=new Point(0, 0);
            panel1.Margin=new Padding(57, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(218, 649);
            panel1.TabIndex=9;
            // 
            // History_btn
            // 
            History_btn.BackColor=Color.FromArgb(64, 64, 64);
            History_btn.FlatStyle=FlatStyle.Flat;
            History_btn.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            History_btn.ForeColor=SystemColors.ButtonHighlight;
            History_btn.Image=(Image)resources.GetObject("History_btn.Image");
            History_btn.ImageAlign=ContentAlignment.MiddleLeft;
            History_btn.Location=new Point(14, 465);
            History_btn.Margin=new Padding(3, 4, 3, 4);
            History_btn.Name="History_btn";
            History_btn.Padding=new Padding(17, 0, 17, 0);
            History_btn.Size=new Size(173, 52);
            History_btn.TabIndex=7;
            History_btn.Text="History";
            History_btn.TextAlign=ContentAlignment.MiddleRight;
            History_btn.UseVisualStyleBackColor=false;
            History_btn.Click+=History_btn_Click;
            // 
            // button3
            // 
            button3.BackColor=Color.FromArgb(64, 64, 64);
            button3.FlatStyle=FlatStyle.Flat;
            button3.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor=SystemColors.ButtonHighlight;
            button3.Image=(Image)resources.GetObject("button3.Image");
            button3.ImageAlign=ContentAlignment.MiddleLeft;
            button3.Location=new Point(14, 199);
            button3.Margin=new Padding(3, 4, 3, 4);
            button3.Name="button3";
            button3.Padding=new Padding(15, 0, 15, 0);
            button3.Size=new Size(173, 48);
            button3.TabIndex=6;
            button3.Text="Account";
            button3.TextAlign=ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor=false;
            button3.Click+=button3_Click;
            // 
            // button2
            // 
            button2.BackColor=Color.FromArgb(64, 64, 64);
            button2.FlatStyle=FlatStyle.Flat;
            button2.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor=SystemColors.ButtonHighlight;
            button2.Image=(Image)resources.GetObject("button2.Image");
            button2.ImageAlign=ContentAlignment.MiddleLeft;
            button2.Location=new Point(14, 283);
            button2.Margin=new Padding(3, 4, 3, 4);
            button2.Name="button2";
            button2.Padding=new Padding(15, 0, 25, 0);
            button2.Size=new Size(173, 48);
            button2.TabIndex=5;
            button2.Text="Print";
            button2.TextAlign=ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor=Color.FromArgb(64, 64, 64);
            button1.FlatStyle=FlatStyle.Flat;
            button1.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.ButtonHighlight;
            button1.Image=(Image)resources.GetObject("button1.Image");
            button1.ImageAlign=ContentAlignment.MiddleLeft;
            button1.Location=new Point(14, 373);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Padding=new Padding(15, 0, 15, 0);
            button1.Size=new Size(173, 48);
            button1.TabIndex=4;
            button1.Text="    Configure";
            button1.TextAlign=ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor=Color.SeaGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Dock=DockStyle.Top;
            panel2.Location=new Point(0, 0);
            panel2.Margin=new Padding(3, 4, 3, 4);
            panel2.Name="panel2";
            panel2.Size=new Size(218, 157);
            panel2.TabIndex=0;
            // 
            // panel6
            // 
            panel6.Controls.Add(Reg_newstudbtn);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(button5);
            panel6.Dock=DockStyle.Bottom;
            panel6.Location=new Point(0, 572);
            panel6.Margin=new Padding(3, 4, 3, 4);
            panel6.Name="panel6";
            panel6.Size=new Size(737, 77);
            panel6.TabIndex=21;
            // 
            // Reg_newstudbtn
            // 
            Reg_newstudbtn.BackColor=Color.SeaGreen;
            Reg_newstudbtn.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Reg_newstudbtn.ForeColor=SystemColors.ButtonHighlight;
            Reg_newstudbtn.ImageAlign=ContentAlignment.MiddleLeft;
            Reg_newstudbtn.Location=new Point(231, 13);
            Reg_newstudbtn.Margin=new Padding(3, 4, 3, 4);
            Reg_newstudbtn.Name="Reg_newstudbtn";
            Reg_newstudbtn.Size=new Size(177, 48);
            Reg_newstudbtn.TabIndex=21;
            Reg_newstudbtn.Text="New Student";
            Reg_newstudbtn.UseVisualStyleBackColor=false;
            Reg_newstudbtn.Click+=Reg_newstudbtn_Click;
            // 
            // button4
            // 
            button4.BackColor=Color.FromArgb(255, 128, 0);
            button4.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor=SystemColors.ButtonHighlight;
            button4.ImageAlign=ContentAlignment.MiddleLeft;
            button4.Location=new Point(24, 13);
            button4.Margin=new Padding(3, 4, 3, 4);
            button4.Name="button4";
            button4.Size=new Size(177, 48);
            button4.TabIndex=19;
            button4.Text="Add Student";
            button4.UseVisualStyleBackColor=false;
            button4.Click+=AddStudBtn;
            // 
            // button5
            // 
            button5.BackColor=Color.FromArgb(192, 0, 0);
            button5.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor=SystemColors.ButtonHighlight;
            button5.ImageAlign=ContentAlignment.MiddleLeft;
            button5.Location=new Point(446, 13);
            button5.Margin=new Padding(3, 4, 3, 4);
            button5.Name="button5";
            button5.Size=new Size(177, 48);
            button5.TabIndex=20;
            button5.Text="Remove Student";
            button5.UseVisualStyleBackColor=false;
            button5.Click+=button5_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.FlatStyle=FlatStyle.Flat;
            label1.Font=new Font("Segoe UI", 24F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label1.Location=new Point(7, 75);
            label1.Name="label1";
            label1.Size=new Size(232, 54);
            label1.TabIndex=11;
            label1.Text="DashBoard";
            label1.Click+=label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Cursor=Cursors.Cross;
            panel3.Dock=DockStyle.Fill;
            panel3.Location=new Point(218, 0);
            panel3.Margin=new Padding(3, 4, 3, 4);
            panel3.Name="panel3";
            panel3.Size=new Size(737, 649);
            panel3.TabIndex=10;
            // 
            // panel7
            // 
            panel7.Controls.Add(StudNational_txtbox);
            panel7.Controls.Add(label2);
            panel7.Cursor=Cursors.Default;
            panel7.Dock=DockStyle.Bottom;
            panel7.Location=new Point(0, 517);
            panel7.Margin=new Padding(3, 4, 3, 4);
            panel7.Name="panel7";
            panel7.Size=new Size(737, 55);
            panel7.TabIndex=33;
            panel7.Paint+=panel7_Paint;
            // 
            // StudNational_txtbox
            // 
            StudNational_txtbox.Location=new Point(231, 8);
            StudNational_txtbox.Margin=new Padding(3, 4, 3, 4);
            StudNational_txtbox.Name="StudNational_txtbox";
            StudNational_txtbox.Size=new Size(294, 27);
            StudNational_txtbox.TabIndex=29;
            StudNational_txtbox.TextChanged+=StudNational_txtbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.SeaGreen;
            label2.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor=SystemColors.ButtonHighlight;
            label2.Location=new Point(7, 12);
            label2.Name="label2";
            label2.Size=new Size(223, 25);
            label2.TabIndex=31;
            label2.Text="Enter Student National Id";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor=SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IdSTU, NameSTU, FacultySTU, LevelSTU, In_timeSTU });
            dataGridView2.Dock=DockStyle.Fill;
            dataGridView2.GridColor=SystemColors.ButtonHighlight;
            dataGridView2.Location=new Point(0, 157);
            dataGridView2.Margin=new Padding(3, 4, 3, 4);
            dataGridView2.Name="dataGridView2";
            dataGridView2.RowHeadersWidth=51;
            dataGridView2.RowTemplate.Height=25;
            dataGridView2.Size=new Size(737, 415);
            dataGridView2.TabIndex=32;
            // 
            // IdSTU
            // 
            IdSTU.HeaderText="National Id";
            IdSTU.MinimumWidth=6;
            IdSTU.Name="IdSTU";
            IdSTU.ReadOnly=true;
            IdSTU.Width=125;
            // 
            // NameSTU
            // 
            NameSTU.HeaderText="Name";
            NameSTU.MinimumWidth=6;
            NameSTU.Name="NameSTU";
            NameSTU.ReadOnly=true;
            NameSTU.Width=125;
            // 
            // FacultySTU
            // 
            FacultySTU.HeaderText="Faculty";
            FacultySTU.MinimumWidth=6;
            FacultySTU.Name="FacultySTU";
            FacultySTU.ReadOnly=true;
            FacultySTU.Width=125;
            // 
            // LevelSTU
            // 
            LevelSTU.HeaderText="Level";
            LevelSTU.MinimumWidth=6;
            LevelSTU.Name="LevelSTU";
            LevelSTU.ReadOnly=true;
            LevelSTU.Width=125;
            // 
            // In_timeSTU
            // 
            In_timeSTU.HeaderText="Time in";
            In_timeSTU.MinimumWidth=6;
            In_timeSTU.Name="In_timeSTU";
            In_timeSTU.ReadOnly=true;
            In_timeSTU.Width=125;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(label1);
            panel5.Dock=DockStyle.Top;
            panel5.Location=new Point(0, 0);
            panel5.Margin=new Padding(3, 4, 3, 4);
            panel5.Name="panel5";
            panel5.Size=new Size(737, 157);
            panel5.TabIndex=28;
            // 
            // panel4
            // 
            panel4.Controls.Add(button9);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock=DockStyle.Right;
            panel4.Location=new Point(531, 0);
            panel4.Margin=new Padding(3, 4, 3, 4);
            panel4.Name="panel4";
            panel4.Size=new Size(206, 157);
            panel4.TabIndex=27;
            panel4.Paint+=panel4_Paint;
            // 
            // button9
            // 
            button9.BackColor=SystemColors.ControlDarkDark;
            button9.Font=new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor=SystemColors.ButtonHighlight;
            button9.Location=new Point(0, 508);
            button9.Margin=new Padding(3, 4, 3, 4);
            button9.Name="button9";
            button9.Size=new Size(253, 49);
            button9.TabIndex=6;
            button9.Text="Check Connection";
            button9.UseVisualStyleBackColor=false;
            button9.Visible=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location=new Point(69, 47);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(137, 111);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=34;
            pictureBox2.TabStop=false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize=new Size(20, 20);
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // program_main_form
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(955, 649);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(emp_name);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3, 4, 3, 4);
            Name="program_main_form";
            StartPosition=FormStartPosition.CenterScreen;
            Text="program_main_form";
            Load+=program_main_form_Load;
            Controls.SetChildIndex(emp_name, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel3, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Log_out_btn;
        private Label emp_name;
        //private string employee_n_id;
        private string name_label_text;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button History;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Button button9;
        private Panel panel6;
        private PictureBox pictureBox2;
        private TextBox StudNational_txtbox;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Button Reg_newstudbtn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IdSTU;
        private DataGridViewTextBoxColumn NameSTU;
        private DataGridViewTextBoxColumn FacultySTU;
        private DataGridViewTextBoxColumn LevelSTU;
        private DataGridViewTextBoxColumn In_timeSTU;
        private Panel panel7;
        private Button History_btn;
    }

}