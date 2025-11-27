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
    public partial class MainInstructorForm: Form
    {
        SQLInstructorManager instrManager = new SQLInstructorManager();
        public MainInstructorForm()
        {
            InitializeComponent();
        }

        private void MainInstructorForm_Load(object sender, EventArgs e)
        {
            try
            {
                InstructorsList_dataGridView.DataSource = instrManager.GetInstructors();
                InstructorsList_dataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            InstructorManager instructorManager = new InstructorManager(instrManager);
            AddInstructorForm addInstructorForm = new AddInstructorForm(instructorManager);
            if (addInstructorForm.ShowDialog() == DialogResult.OK)
            {
                InstructorsList_dataGridView.DataSource = instrManager.GetInstructors();
            }
        }
        public void SearchData(string searchText)
        {
            InstructorsList_dataGridView.CurrentCell = null;
            int[] searchColumn = { 1, 2, 4 };
            foreach (DataGridViewRow row in InstructorsList_dataGridView.Rows)
            {
                bool found = false;
                foreach (int searchCell in searchColumn)
                {
                    if (row.Cells[searchCell].Value != null && row.Cells[searchCell].Value.ToString().ToLower().Contains(searchText.ToLower())) { found = true; }
                }
                row.Visible = found;
            }
        }
        private void InstructorsList_dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // Клик в пустой области (не на строке, не на заголовке, не на ячейке)
            //                         координыты клика   в какую область попал клик
            if (InstructorsList_dataGridView.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                InstructorsList_dataGridView.ClearSelection();
                InstructorsList_dataGridView.CurrentCell = null;
            }
        }
    }
}
