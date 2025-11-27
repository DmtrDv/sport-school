using SportSchoolLib.WrittenOffInventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSportSchool.inventories
{
    public partial class ArchiveForm : Form
    {
        SQLWriteOffManager SqlWriteOffManager = new SQLWriteOffManager();
        public ArchiveForm()
        {
            InitializeComponent();
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {
            try
            {
                archive_dataGridView.DataSource = SqlWriteOffManager.GetWrittenOffArchive();
                archive_dataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
        public void SearchData(string searchText)
        {
            archive_dataGridView.CurrentCell = null;
            int[] searchColumn = { 1, 2 };
            foreach (DataGridViewRow row in archive_dataGridView.Rows)
            {
                bool found = false;
                foreach (int searchCell in searchColumn)
                {
                    if (row.Cells[searchCell].Value != null && row.Cells[searchCell].Value.ToString().ToLower().Contains(searchText.ToLower())) { found = true; }
                }
                row.Visible = found;
            }
        }

        private void archive_dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // Клик в пустой области (не на строке, не на заголовке, не на ячейке)
            //                         координыты клика   в какую область попал клик
            if (archive_dataGridView.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                archive_dataGridView.ClearSelection();
                archive_dataGridView.CurrentCell = null;
            }
        }
    }
}
