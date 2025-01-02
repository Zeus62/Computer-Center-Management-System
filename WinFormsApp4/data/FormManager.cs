using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.data
{
    internal class FormManager
    {
        private Dictionary<string, Form> forms = new Dictionary<string, Form>();

        public void AddForm(string formName, Form form)
        {
            if (!forms.ContainsKey(formName))
            {
                forms.Add(formName, form);
            }
        }

        public Form GetForm(string formName)
        {
            if (forms.ContainsKey(formName))
            {
                return forms[formName];
            }

            return null;
        }

        public void RemoveForm(string formName)
        {
            if (forms.ContainsKey(formName))
            {
                forms[formName].Dispose();
                forms.Remove(formName);
            }
        }

        public void ShowForm(string formName)
        {
            if (forms.ContainsKey(formName))
            {
                forms[formName].Show();
            }
        }

        public void HideForm(string formName)
        {
            if (forms.ContainsKey(formName))
            {
                forms[formName].Hide();
            }
        }

        public void CloseForm(string formName)
        {
            if (forms.ContainsKey(formName))
            {
                forms[formName].Close();
                forms.Remove(formName);
            }
        }
    }
}
