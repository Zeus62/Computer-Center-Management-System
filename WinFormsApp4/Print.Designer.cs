namespace WinFormsApp4
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            pictureBox3=new PictureBox();
            panel1=new Panel();
            label2=new Label();
            name_lbl=new Label();
            tt_cost=new TextBox();
            Num_pg_tb=new TextBox();
            label1=new Label();
            label3=new Label();
            textBox1=new TextBox();
            button1=new Button();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image=(Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location=new Point(-7, 107);
            pictureBox3.Margin=new Padding(3, 4, 3, 4);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(317, 363);
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex=21;
            pictureBox3.TabStop=false;
            // 
            // panel1
            // 
            panel1.AutoSize=true;
            panel1.BackColor=Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock=DockStyle.Left;
            panel1.Location=new Point(0, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(313, 512);
            panel1.TabIndex=42;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.Transparent;
            label2.Font=new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.SeaGreen;
            label2.Location=new Point(381, 321);
            label2.Name="label2";
            label2.Size=new Size(116, 30);
            label2.TabIndex=46;
            label2.Text="Total Cost";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize=true;
            name_lbl.BackColor=Color.Transparent;
            name_lbl.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            name_lbl.ForeColor=Color.SeaGreen;
            name_lbl.Location=new Point(381, 261);
            name_lbl.Name="name_lbl";
            name_lbl.Size=new Size(169, 25);
            name_lbl.TabIndex=45;
            name_lbl.Text="Number Of Pages";
            // 
            // tt_cost
            // 
            tt_cost.Location=new Point(381, 357);
            tt_cost.Margin=new Padding(3, 4, 3, 4);
            tt_cost.Name="tt_cost";
            tt_cost.ReadOnly=true;
            tt_cost.Size=new Size(178, 27);
            tt_cost.TabIndex=44;
            // 
            // Num_pg_tb
            // 
            Num_pg_tb.Location=new Point(381, 291);
            Num_pg_tb.Margin=new Padding(3, 4, 3, 4);
            Num_pg_tb.Name="Num_pg_tb";
            Num_pg_tb.Size=new Size(196, 27);
            Num_pg_tb.TabIndex=43;
            Num_pg_tb.TextChanged+=Num_pg_tb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.Transparent;
            label1.Font=new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(400, 69);
            label1.Name="label1";
            label1.Size=new Size(126, 54);
            label1.TabIndex=48;
            label1.Text="Print ";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.Transparent;
            label3.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.SeaGreen;
            label3.Location=new Point(381, 199);
            label3.Name="label3";
            label3.Size=new Size(108, 25);
            label3.TabIndex=49;
            label3.Text="Student ID";
            label3.Click+=label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(382, 228);
            textBox1.Margin=new Padding(3, 4, 3, 4);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(196, 27);
            textBox1.TabIndex=50;
            // 
            // button1
            // 
            button1.BackColor=Color.SeaGreen;
            button1.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.ButtonHighlight;
            button1.ImageAlign=ContentAlignment.MiddleLeft;
            button1.Location=new Point(381, 423);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Size=new Size(89, 48);
            button1.TabIndex=51;
            button1.Text="Exit";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.BackColor=Color.SeaGreen;
            button2.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor=SystemColors.ButtonHighlight;
            button2.ImageAlign=ContentAlignment.MiddleLeft;
            button2.Location=new Point(469, 423);
            button2.Margin=new Padding(3, 4, 3, 4);
            button2.Name="button2";
            button2.Size=new Size(89, 48);
            button2.TabIndex=52;
            button2.Text="Print";
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click;
            // 
            // Print
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            ClientSize=new Size(642, 512);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name_lbl);
            Controls.Add(tt_cost);
            Controls.Add(Num_pg_tb);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Print";
            Text="Print";
            Load+=Print_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(Num_pg_tb, 0);
            Controls.SetChildIndex(tt_cost, 0);
            Controls.SetChildIndex(name_lbl, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Label name_lbl;
        private TextBox tt_cost;
        private TextBox Num_pg_tb;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}