using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using funcs;
using WinFormsApp4.data;

namespace WinFormsApp4
{
    public partial class HistoryForm : DraggablePanel
    {
        public HistoryForm()
        {
            InitializeComponent();
            fun();
        }
        private void fun(string id = null)
        {
            Histroty_dgridview.Rows.Clear();
            List<List<string>> k;
            if (id == null)
                k = DataBaseMethods.GetInHistoryView();
            else
                k = DataBaseMethods.GetInHistoryView(id);

            foreach (var i in k)
            {
                Histroty_dgridview.Rows.Add(i[0], i[1], i[2], i[3], i[4], i[5], i[6]);
            }
        }
        AppDbContext db = AppDbContext.Instance;

        private void HirtoryForm_Load(object sender, EventArgs e)
        {
            var historyData = db.history
                .Select((h) => new
                {
                    StudentID = h.student_n_id,
                    TimeIn = h.time_in,
                    TimeOut = h.time_out,
                    Date = h.date,
                    Cost = h.cost,
                    PaperCount = h.paper_count
                }
                ).ToList();
            // Histroty_dgridview.DataSource = historyData;
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search_txtbox.Text))
            {
                fun();
                return;
            }
            else if (Search_txtbox.Text=="1")
            {
                fun("1");
                return;
            }
            else if (!ValidationMethods.NationalIdLen(Search_txtbox.Text))
            {
                MessageBox.Show("Wrong National ID");
                return;
            }
            fun(Search_txtbox.Text);
        }

        private void Histroty_dgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Histroty_dgridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clear_filter_btn_Click(object sender, EventArgs e)
        {
            fun();
        }
    }
}
