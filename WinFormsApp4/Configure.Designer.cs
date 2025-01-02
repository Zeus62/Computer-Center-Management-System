namespace WinFormsApp4
{
    partial class Configure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configure));
            Reg_newstudbtn=new Button();
            label3=new Label();
            label2=new Label();
            label1=new Label();
            name_lbl=new Label();
            cost_per_page=new TextBox();
            cost_per_hour=new TextBox();
            panel1=new Panel();
            pictureBox2=new PictureBox();
            dateTimePicker1=new DateTimePicker();
            autoCheck_checkbox=new CheckBox();
            enableRound_checkbox=new CheckBox();
            numericUpDown1=new NumericUpDown();
            label4=new Label();
            comboBox1=new ComboBox();
            currency1=new Label();
            currency2=new Label();
            currency3=new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Reg_newstudbtn
            // 
            Reg_newstudbtn.BackColor=Color.SeaGreen;
            Reg_newstudbtn.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Reg_newstudbtn.ForeColor=SystemColors.ButtonHighlight;
            Reg_newstudbtn.ImageAlign=ContentAlignment.MiddleLeft;
            Reg_newstudbtn.Location=new Point(334, 608);
            Reg_newstudbtn.Margin=new Padding(3, 4, 3, 4);
            Reg_newstudbtn.Name="Reg_newstudbtn";
            Reg_newstudbtn.Size=new Size(177, 48);
            Reg_newstudbtn.TabIndex=58;
            Reg_newstudbtn.Text="Save Changes";
            Reg_newstudbtn.UseVisualStyleBackColor=false;
            Reg_newstudbtn.Click+=Reg_newstudbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.Transparent;
            label3.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.SeaGreen;
            label3.Location=new Point(18, 427);
            label3.Name="label3";
            label3.Size=new Size(242, 37);
            label3.TabIndex=57;
            label3.Text="Round to Nearest";
            label3.TextAlign=ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.Transparent;
            label2.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.SeaGreen;
            label2.Location=new Point(18, 192);
            label2.Name="label2";
            label2.Size=new Size(204, 74);
            label2.TabIndex=56;
            label2.Text="Cost Per Paper\r\n (Print)";
            label2.TextAlign=ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.Transparent;
            label1.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(18, 309);
            label1.Name="label1";
            label1.Size=new Size(183, 37);
            label1.TabIndex=60;
            label1.Text="Closing Time";
            label1.TextAlign=ContentAlignment.TopCenter;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize=true;
            name_lbl.BackColor=Color.Transparent;
            name_lbl.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            name_lbl.ForeColor=Color.SeaGreen;
            name_lbl.Location=new Point(18, 96);
            name_lbl.Name="name_lbl";
            name_lbl.Size=new Size(195, 37);
            name_lbl.TabIndex=55;
            name_lbl.Text="Cost Per Hour";
            name_lbl.TextAlign=ContentAlignment.TopCenter;
            // 
            // cost_per_page
            // 
            cost_per_page.Font=new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cost_per_page.Location=new Point(247, 203);
            cost_per_page.Margin=new Padding(3, 4, 3, 4);
            cost_per_page.Name="cost_per_page";
            cost_per_page.Size=new Size(356, 52);
            cost_per_page.TabIndex=52;
            cost_per_page.Text="0.5";
            // 
            // cost_per_hour
            // 
            cost_per_hour.Font=new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cost_per_hour.Location=new Point(247, 85);
            cost_per_hour.Margin=new Padding(3, 4, 3, 4);
            cost_per_hour.Name="cost_per_hour";
            cost_per_hour.Size=new Size(356, 52);
            cost_per_hour.TabIndex=51;
            cost_per_hour.Text="6";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Dock=DockStyle.Right;
            panel1.Location=new Point(677, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(251, 693);
            panel1.TabIndex=59;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock=DockStyle.Bottom;
            pictureBox2.Image=Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location=new Point(0, 432);
            pictureBox2.Margin=new Padding(3, 4, 3, 4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(251, 261);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=34;
            pictureBox2.TabStop=false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop=true;
            dateTimePicker1.CustomFormat="h:mm tt";
            dateTimePicker1.Font=new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format=DateTimePickerFormat.Custom;
            dateTimePicker1.Location=new Point(247, 299);
            dateTimePicker1.Margin=new Padding(3, 4, 3, 4);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.Size=new Size(356, 52);
            dateTimePicker1.TabIndex=61;
            dateTimePicker1.Value=new DateTime(2023, 12, 25, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged+=dateTimePicker1_ValueChanged;
            // 
            // autoCheck_checkbox
            // 
            autoCheck_checkbox.AutoSize=true;
            autoCheck_checkbox.Location=new Point(247, 363);
            autoCheck_checkbox.Margin=new Padding(3, 4, 3, 4);
            autoCheck_checkbox.Name="autoCheck_checkbox";
            autoCheck_checkbox.Size=new Size(250, 24);
            autoCheck_checkbox.TabIndex=62;
            autoCheck_checkbox.Text="Auto Checkout Students on Close";
            autoCheck_checkbox.UseVisualStyleBackColor=true;
            // 
            // enableRound_checkbox
            // 
            enableRound_checkbox.AutoSize=true;
            enableRound_checkbox.Location=new Point(247, 480);
            enableRound_checkbox.Margin=new Padding(3, 4, 3, 4);
            enableRound_checkbox.Name="enableRound_checkbox";
            enableRound_checkbox.Size=new Size(144, 24);
            enableRound_checkbox.TabIndex=63;
            enableRound_checkbox.Text="Enable Rounding";
            enableRound_checkbox.UseVisualStyleBackColor=true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces=2;
            numericUpDown1.Font=new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Increment=new decimal(new int[] { 25, 0, 0, 131072 });
            numericUpDown1.Location=new Point(247, 416);
            numericUpDown1.Margin=new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum=new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.ReadOnly=true;
            numericUpDown1.Size=new Size(357, 52);
            numericUpDown1.TabIndex=64;
            numericUpDown1.TextAlign=HorizontalAlignment.Center;
            numericUpDown1.Value=new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown1.ValueChanged+=numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.Transparent;
            label4.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor=Color.SeaGreen;
            label4.Location=new Point(18, 523);
            label4.Name="label4";
            label4.Size=new Size(131, 37);
            label4.TabIndex=65;
            label4.Text="Currency";
            label4.TextAlign=ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled=true;
            comboBox1.Items.AddRange(new object[] { "Egyptian Pound (EGP)", "United States Dollar (USD)" });
            comboBox1.Location=new Point(247, 523);
            comboBox1.Margin=new Padding(3, 4, 3, 4);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(356, 44);
            comboBox1.TabIndex=66;
            comboBox1.Text="Egyptian Pound (EGP)";
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged;
            // 
            // currency1
            // 
            currency1.AutoSize=true;
            currency1.Font=new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            currency1.Location=new Point(613, 85);
            currency1.Name="currency1";
            currency1.Size=new Size(79, 46);
            currency1.TabIndex=67;
            currency1.Text="EGP";
            // 
            // currency2
            // 
            currency2.AutoSize=true;
            currency2.Font=new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            currency2.Location=new Point(613, 203);
            currency2.Name="currency2";
            currency2.Size=new Size(79, 46);
            currency2.TabIndex=68;
            currency2.Text="EGP";
            // 
            // currency3
            // 
            currency3.AutoSize=true;
            currency3.Font=new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            currency3.Location=new Point(613, 416);
            currency3.Name="currency3";
            currency3.Size=new Size(79, 46);
            currency3.TabIndex=69;
            currency3.Text="EGP";
            // 
            // Configure
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(928, 693);
            Controls.Add(currency3);
            Controls.Add(currency1);
            Controls.Add(currency2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(enableRound_checkbox);
            Controls.Add(autoCheck_checkbox);
            Controls.Add(dateTimePicker1);
            Controls.Add(Reg_newstudbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name_lbl);
            Controls.Add(cost_per_page);
            Controls.Add(cost_per_hour);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3, 4, 3, 4);
            Name="Configure";
            Text="Configure";
            Load+=Configure_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(cost_per_hour, 0);
            Controls.SetChildIndex(cost_per_page, 0);
            Controls.SetChildIndex(name_lbl, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(Reg_newstudbtn, 0);
            Controls.SetChildIndex(dateTimePicker1, 0);
            Controls.SetChildIndex(autoCheck_checkbox, 0);
            Controls.SetChildIndex(enableRound_checkbox, 0);
            Controls.SetChildIndex(numericUpDown1, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(currency2, 0);
            Controls.SetChildIndex(currency1, 0);
            Controls.SetChildIndex(currency3, 0);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Reg_newstudbtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label name_lbl;
        private TextBox cost_per_page;
        private TextBox cost_per_hour;
        private Panel panel1;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1;
        private CheckBox autoCheck_checkbox;
        private CheckBox enableRound_checkbox;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private ComboBox comboBox1;
        private Label currency1;
        private Label currency2;
        private Label currency3;
    }
}