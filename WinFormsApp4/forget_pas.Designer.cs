namespace WinFormsApp4
{
    partial class forget_pas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forget_pas));
            email_txtbox=new TextBox();
            label3=new Label();
            textBox1=new TextBox();
            label1=new Label();
            textBox2=new TextBox();
            textBox3=new TextBox();
            label5=new Label();
            label2=new Label();
            button1=new Button();
            pictureBox2=new PictureBox();
            button2=new Button();
            button3=new Button();
            label4=new Label();
            sqlCommand1=new Microsoft.Data.SqlClient.SqlCommand();
            label8=new Label();
            label9=new Label();
            checkBox1=new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // email_txtbox
            // 
            email_txtbox.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_txtbox.ForeColor=Color.SeaGreen;
            email_txtbox.Location=new Point(136, 85);
            email_txtbox.Margin=new Padding(3, 4, 3, 4);
            email_txtbox.Name="email_txtbox";
            email_txtbox.Size=new Size(252, 27);
            email_txtbox.TabIndex=11;
            email_txtbox.TextChanged+=email_txtbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.SeaGreen;
            label3.Location=new Point(136, 61);
            label3.Name="label3";
            label3.Size=new Size(132, 21);
            label3.TabIndex=10;
            label3.Text="Enter an Email";
            // 
            // textBox1
            // 
            textBox1.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor=Color.SeaGreen;
            textBox1.Location=new Point(136, 249);
            textBox1.Margin=new Padding(3, 4, 3, 4);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(252, 27);
            textBox1.TabIndex=13;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(136, 224);
            label1.Name="label1";
            label1.Size=new Size(235, 21);
            label1.TabIndex=12;
            label1.Text="Enter Authentication Code";
            // 
            // textBox2
            // 
            textBox2.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor=Color.SeaGreen;
            textBox2.Location=new Point(136, 409);
            textBox2.Margin=new Padding(3, 4, 3, 4);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(252, 27);
            textBox2.TabIndex=15;
            // 
            // textBox3
            // 
            textBox3.Font=new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor=Color.SeaGreen;
            textBox3.Location=new Point(136, 477);
            textBox3.Margin=new Padding(3, 4, 3, 4);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(252, 27);
            textBox3.TabIndex=17;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor=Color.SeaGreen;
            label5.Location=new Point(136, 384);
            label5.Name="label5";
            label5.Size=new Size(93, 21);
            label5.TabIndex=18;
            label5.Text="Password";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.SeaGreen;
            label2.Location=new Point(136, 452);
            label2.Name="label2";
            label2.Size=new Size(172, 21);
            label2.TabIndex=19;
            label2.Text="Re-Enter Password";
            // 
            // button1
            // 
            button1.BackColor=Color.SeaGreen;
            button1.FlatStyle=FlatStyle.Popup;
            button1.ForeColor=SystemColors.ButtonHighlight;
            button1.Location=new Point(136, 123);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Size=new Size(86, 31);
            button1.TabIndex=20;
            button1.Text="Send email";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location=new Point(451, 145);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(341, 319);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=34;
            pictureBox2.TabStop=false;
            // 
            // button2
            // 
            button2.BackColor=Color.SeaGreen;
            button2.FlatStyle=FlatStyle.Popup;
            button2.ForeColor=SystemColors.ButtonHighlight;
            button2.Location=new Point(138, 540);
            button2.Margin=new Padding(3, 4, 3, 4);
            button2.Name="button2";
            button2.Size=new Size(86, 31);
            button2.TabIndex=36;
            button2.Text="Change";
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.BackColor=Color.SeaGreen;
            button3.FlatStyle=FlatStyle.Popup;
            button3.ForeColor=SystemColors.ButtonHighlight;
            button3.Location=new Point(136, 285);
            button3.Margin=new Padding(3, 4, 3, 4);
            button3.Name="button3";
            button3.Size=new Size(86, 31);
            button3.TabIndex=37;
            button3.Text="Submit";
            button3.UseVisualStyleBackColor=false;
            button3.Click+=button3_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor=Color.SeaGreen;
            label4.Location=new Point(25, 85);
            label4.Name="label4";
            label4.Size=new Size(72, 28);
            label4.TabIndex=38;
            label4.Text="Step 1";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout=30;
            sqlCommand1.Connection=null;
            sqlCommand1.Notification=null;
            sqlCommand1.Transaction=null;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor=Color.SeaGreen;
            label8.Location=new Point(25, 452);
            label8.Name="label8";
            label8.Size=new Size(72, 28);
            label8.TabIndex=41;
            label8.Text="Step 3";
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor=Color.SeaGreen;
            label9.Location=new Point(25, 249);
            label9.Name="label9";
            label9.Size=new Size(72, 28);
            label9.TabIndex=42;
            label9.Text="Step 2";
            // 
            // checkBox1
            // 
            checkBox1.Anchor=AnchorStyles.None;
            checkBox1.AutoSize=true;
            checkBox1.Font=new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location=new Point(137, 511);
            checkBox1.Margin=new Padding(3, 4, 3, 4);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(126, 23);
            checkBox1.TabIndex=43;
            checkBox1.Text="Show Password";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // forget_pas
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(822, 636);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(email_txtbox);
            Controls.Add(label3);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3, 4, 3, 4);
            Name="forget_pas";
            Text="forget_pas";
            Load+=forget_pas_Load;
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(email_txtbox, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(textBox2, 0);
            Controls.SetChildIndex(textBox3, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(pictureBox2, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(checkBox1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_txtbox;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label8;
        private Label label9;
        private CheckBox checkBox1;
    }
}