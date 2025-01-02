namespace WinFormsApp4
{
    partial class New_stu_reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_stu_reg));
            name_txtbox=new TextBox();
            Faculty_txtbox=new TextBox();
            N_id_txtbox=new TextBox();
            Level_txtbox=new TextBox();
            name_lbl=new Label();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            Reg_newstudbtn=new Button();
            pictureBox2=new PictureBox();
            panel1=new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // name_txtbox
            // 
            name_txtbox.Location=new Point(73, 96);
            name_txtbox.Margin=new Padding(3, 4, 3, 4);
            name_txtbox.Name="name_txtbox";
            name_txtbox.Size=new Size(268, 27);
            name_txtbox.TabIndex=0;
            name_txtbox.TextChanged+=name_txtbox_TextChanged;
            // 
            // Faculty_txtbox
            // 
            Faculty_txtbox.Location=new Point(73, 245);
            Faculty_txtbox.Margin=new Padding(3, 4, 3, 4);
            Faculty_txtbox.Name="Faculty_txtbox";
            Faculty_txtbox.Size=new Size(268, 27);
            Faculty_txtbox.TabIndex=2;
            Faculty_txtbox.TextChanged+=Faculty_txtbox_TextChanged;
            // 
            // N_id_txtbox
            // 
            N_id_txtbox.Location=new Point(73, 169);
            N_id_txtbox.Margin=new Padding(3, 4, 3, 4);
            N_id_txtbox.Name="N_id_txtbox";
            N_id_txtbox.Size=new Size(268, 27);
            N_id_txtbox.TabIndex=1;
            N_id_txtbox.TextChanged+=N_id_txtbox_TextChanged;
            // 
            // Level_txtbox
            // 
            Level_txtbox.Location=new Point(73, 323);
            Level_txtbox.Margin=new Padding(3, 4, 3, 4);
            Level_txtbox.Name="Level_txtbox";
            Level_txtbox.Size=new Size(268, 27);
            Level_txtbox.TabIndex=3;
            Level_txtbox.TextChanged+=Level_txtbox_TextChanged;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize=true;
            name_lbl.BackColor=Color.Transparent;
            name_lbl.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            name_lbl.ForeColor=Color.SeaGreen;
            name_lbl.Location=new Point(73, 64);
            name_lbl.Name="name_lbl";
            name_lbl.Size=new Size(64, 25);
            name_lbl.TabIndex=4;
            name_lbl.Text="Name";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.Transparent;
            label1.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(73, 215);
            label1.Name="label1";
            label1.Size=new Size(74, 25);
            label1.TabIndex=50;
            label1.Text="Faculty";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.Transparent;
            label2.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.SeaGreen;
            label2.Location=new Point(73, 147);
            label2.Name="label2";
            label2.Size=new Size(113, 25);
            label2.TabIndex=10;
            label2.Text="National ID";
            label2.Click+=label2_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.Transparent;
            label3.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.SeaGreen;
            label3.Location=new Point(73, 292);
            label3.Name="label3";
            label3.Size=new Size(57, 25);
            label3.TabIndex=11;
            label3.Text="Level";
            // 
            // Reg_newstudbtn
            // 
            Reg_newstudbtn.BackColor=Color.SeaGreen;
            Reg_newstudbtn.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Reg_newstudbtn.ForeColor=SystemColors.ButtonHighlight;
            Reg_newstudbtn.ImageAlign=ContentAlignment.MiddleLeft;
            Reg_newstudbtn.Location=new Point(122, 395);
            Reg_newstudbtn.Margin=new Padding(3, 4, 3, 4);
            Reg_newstudbtn.Name="Reg_newstudbtn";
            Reg_newstudbtn.Size=new Size(177, 48);
            Reg_newstudbtn.TabIndex=22;
            Reg_newstudbtn.Text="New Student";
            Reg_newstudbtn.UseVisualStyleBackColor=false;
            Reg_newstudbtn.Click+=Reg_newstudbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock=DockStyle.Bottom;
            pictureBox2.Image=Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location=new Point(0, 326);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(207, 261);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=34;
            pictureBox2.TabStop=false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Dock=DockStyle.Right;
            panel1.Location=new Point(496, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(207, 587);
            panel1.TabIndex=35;
            panel1.Paint+=panel1_Paint;
            // 
            // New_stu_reg
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(703, 587);
            Controls.Add(Reg_newstudbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name_lbl);
            Controls.Add(Level_txtbox);
            Controls.Add(N_id_txtbox);
            Controls.Add(Faculty_txtbox);
            Controls.Add(name_txtbox);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3, 4, 3, 4);
            Name="New_stu_reg";
            Text="reg";
            Load+=New_stu_reg_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(name_txtbox, 0);
            Controls.SetChildIndex(Faculty_txtbox, 0);
            Controls.SetChildIndex(N_id_txtbox, 0);
            Controls.SetChildIndex(Level_txtbox, 0);
            Controls.SetChildIndex(name_lbl, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(Reg_newstudbtn, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_txtbox;
        private TextBox Faculty_txtbox;
        private TextBox N_id_txtbox;
        private TextBox Level_txtbox;
        private Label name_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Reg_newstudbtn;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}