using SportSchoolLib;
using SportSchoolLib.Inventors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormSportSchool.inventories;

namespace WinFormSportSchool.reports
{
    public partial class ReportsForm : Form
    {
        SqlReports sqlReports = new SqlReports();
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void rep1_label_MouseClick(object sender, MouseEventArgs e)
        {
            RepForm rep = new RepForm(sqlReports);
            rep.Text = "Низкий запас инвентаря";
            rep.Show();
        }

        private void rep1_label_MouseMove(object sender, MouseEventArgs e)
        {
           rep1_label.ForeColor = Color.CadetBlue;
        }

        private void rep1_label_MouseLeave(object sender, EventArgs e)
        {
            rep1_label.ForeColor = Color.Black;
        }
    }
}
