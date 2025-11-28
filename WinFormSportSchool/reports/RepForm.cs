using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportSchoolLib;
using System.Windows.Forms;
using SportSchoolLib.WrittenOffInventory;

namespace WinFormSportSchool.reports
{
    public partial class RepForm : Form
    {
        private SqlReports sqlReports_;

        public RepForm(SqlReports sqlReports)
        {
            InitializeComponent();
            sqlReports_ = sqlReports;
        }

        private void RepForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView.DataSource = sqlReports_.GetLowInventoryStock();
                dataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
