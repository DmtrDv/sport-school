using SportSchoolLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSportSchool
{
    public partial class MainTraineeForm : Form
    {
        SQLTraineeManager traineeManager = new SQLTraineeManager();
        public MainTraineeForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                tableListTrainees_dataGridView.DataSource = traineeManager.GetListTrainee();
                tableListTrainees_dataGridView.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTrainee_button_Click(object sender, EventArgs e)
        {
            TraineeDBManager traineeDBManager = new TraineeDBManager(traineeManager);
            AddTraineeForm addTraineeForm = new AddTraineeForm(traineeDBManager);
            if (addTraineeForm.ShowDialog() == DialogResult.OK)
            {
                tableListTrainees_dataGridView.DataSource = traineeManager.GetListTrainee();
            }
        }
        public void SearchData(string searchText)
        {
            tableListTrainees_dataGridView.CurrentCell = null;
            int[] searchColumn = { 1, 3, 4 };
            foreach (DataGridViewRow row in tableListTrainees_dataGridView.Rows)
            {
                bool found = false;
                foreach (int searchCell in searchColumn)
                {
                    if (row.Cells[searchCell].Value != null && row.Cells[searchCell].Value.ToString().ToLower().Contains(searchText.ToLower())) { found = true; }
                }
                row.Visible = found;
            }
        }
        private void tableListTrainees_dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // Клик в пустой области (не на строке, не на заголовке, не на ячейке)
            //                         координыты клика   в какую область попал клик
            if (tableListTrainees_dataGridView.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                tableListTrainees_dataGridView.ClearSelection();
                tableListTrainees_dataGridView.CurrentCell = null;
            }
        }
    }
}
