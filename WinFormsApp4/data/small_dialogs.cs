using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace WinFormsApp4.data
{
    internal class small_dialogs
    {
    }


    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, bool isPassword = false)
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                Font = new Font("Arial", 11) 
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Width = 300,
                Text = text,
                Font = new Font("Arial", 11),  
                ForeColor = Color.Black 
            };
            TextBox textBox = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 300,
                Font = new Font("Arial", 11, FontStyle.Regular), 
                BorderStyle = BorderStyle.FixedSingle,  
                BackColor = isPassword ? Color.FromArgb(240, 240, 240) : Color.White,  
                UseSystemPasswordChar = isPassword,
                PasswordChar = isPassword ? '•' : '\0'  
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 130,
                Width = 90,
                Top = 100,
                DialogResult = DialogResult.OK,
                Font = new Font("Arial", 11, FontStyle.Bold), 
                ForeColor = Color.White,
                BackColor = Color.SeaGreen,  
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }




}
