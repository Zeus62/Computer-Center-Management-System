using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Configure : DraggablePanel
    {

        bool isDebugMode = false;
        public Configure()
        {
            InitializeComponent();
        }



        private void Configure_Load(object sender, EventArgs e)
        {
            cost_per_hour.Text = SharedValues.CostPerHour.ToString();
            cost_per_page.Text = SharedValues.CostPerPaper.ToString();
            dateTimePicker1.Value = DateTime.Today + SharedValues.ClosingTime;
            numericUpDown1.Value = (decimal)SharedValues.RoundingValue;
            comboBox1.SelectedItem = SharedValues.SelectedCurrency;
            autoCheck_checkbox.Checked = SharedValues.AutoCheckOutStudents;
            enableRound_checkbox.Checked = SharedValues.EnableRound;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
                numericUpDown1.Increment = 0.25M;
            else if (numericUpDown1.Value < 25)
            {
                if (numericUpDown1.Value == 6)
                    numericUpDown1.Value = 5;
                numericUpDown1.Increment = 5;
            }
            else if (numericUpDown1.Value < 100)
                numericUpDown1.Increment = 25;
            else
                numericUpDown1.Increment = 100;
        }

        private string ExtractCurrencyCode(string value)
        {
            string selectedCurrency = value;
            Match match = Regex.Match(selectedCurrency, @"\((\w+)\)");
            string currencyCode = match.Groups[1].Value;
            return currencyCode;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currencyCode = ExtractCurrencyCode(comboBox1.SelectedItem.ToString());
            currency1.Text = currency2.Text = currency3.Text = currencyCode;
        }

        private void Reg_newstudbtn_Click(object sender, EventArgs e)
        {
            SharedValues.CostPerHour = float.TryParse(cost_per_hour.Text, out float costHour) ? costHour : 0;
            SharedValues.CostPerPaper = float.TryParse(cost_per_page.Text, out float costPaper) ? costPaper : 0;
            SharedValues.ClosingTime = dateTimePicker1.Value.TimeOfDay;
            SharedValues.RoundingValue = (double)numericUpDown1.Value;
            SharedValues.SelectedCurrency = comboBox1.SelectedItem?.ToString();
            SharedValues.AutoCheckOutStudents = autoCheck_checkbox.Checked;
            SharedValues.EnableRound = enableRound_checkbox.Checked;

            this.Close();


            // Debug Part
            if (isDebugMode)
            {
                MessageBox.Show($"Cost per hour: {SharedValues.CostPerHour}\n" +
                                $"Cost per paper: {SharedValues.CostPerPaper}\n" +
                                $"Selected date and time: {SharedValues.ClosingTime}\n" +
                                $"Numeric value: {SharedValues.RoundingValue}\n" +
                                $"Selected currency: {SharedValues.SelectedCurrency}\n" +
                                $"Auto Check Out Students: {SharedValues.AutoCheckOutStudents}\n" +
                                $"Enable Round: {SharedValues.EnableRound}");

            }
        }

        // Empty Functions
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
