using SportSchoolLib;
using SportSchoolLib.Inventors;
using System;
using SportSchoolLib.WrittenOffInventory;
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
    public partial class MainInventoryForm: Form
    {
        SQLInventoryManager SqlInventoryManager = new SQLInventoryManager();
        SQLWriteOffManager SqlWriteOffManager = new SQLWriteOffManager();
        public MainInventoryForm()
        {
            InitializeComponent();
        }

        private void MainInventoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                InventoryList_dataGridView.DataSource = SqlInventoryManager.GetInventories();
                InventoryList_dataGridView.ClearSelection();
                InventoryList_dataGridView.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchData(string searchText)
        {
            InventoryList_dataGridView.CurrentCell = null;
            int[] searchColumn = { 1, 2};
            foreach (DataGridViewRow row in InventoryList_dataGridView.Rows)
            {
                bool found = false;
                foreach (int searchCell in searchColumn)
                {
                    if (row.Cells[searchCell].Value != null && row.Cells[searchCell].Value.ToString().ToLower().Contains(searchText.ToLower())) {found = true;}
                }
                row.Visible = found;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            InventoryManager inventoryManager = new InventoryManager(SqlInventoryManager);
            AddInvetoryForm addInventoryForm = new AddInvetoryForm(inventoryManager);
            addInventoryForm.Text = "Добавить инвентарь";
            if (addInventoryForm.ShowDialog() == DialogResult.OK)
            {
                InventoryList_dataGridView.DataSource = SqlInventoryManager.GetInventories();
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (InventoryList_dataGridView.SelectedRows.Count > 0) //выбрана ли строка для редактирования
            {
                Inventory selectedInventory = InventoryList_dataGridView.SelectedRows[0].DataBoundItem as Inventory; //получаем выбранную строку

                // Если инвентарь добавлен не более трёх дней назад
                if (!(selectedInventory.DateDelivery.Date <= DateTime.Now.Date.AddDays(-3)))
                {
                    Inventory editingInventory = selectedInventory.Clone();
                    InventoryManager inventoryManager = new InventoryManager(SqlInventoryManager);
                    EditInventoryForm editInventoryForm = new EditInventoryForm(inventoryManager, editingInventory);
                    if (editInventoryForm.ShowDialog() == DialogResult.OK) // если результат диалога ОК, то меняем значения
                    {
                        selectedInventory.Name_Inventory = editingInventory.Name_Inventory;
                        selectedInventory.Count_Inventory = editingInventory.Count_Inventory;
                        selectedInventory.DateDelivery = editingInventory.DateDelivery;
                    }
                }
                else
                {
                    MessageBox.Show("Нельзя редактировать инвентарь, добавленный более трёх дней назад", "Редактирование запрещено",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Выберите инвентарь для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InventoryList_dataGridView_MouseDown(object sender, MouseEventArgs e)
        {

            // Клик в пустой области (не на строке, не на заголовке, не на ячейке)
            //                         координыты клика   в какую область попал клик
            if (InventoryList_dataGridView.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                InventoryList_dataGridView.ClearSelection();
                InventoryList_dataGridView.CurrentCell = null;
            }
        }
        private void WriteOff_button_Click(object sender, EventArgs e)
        {
            if (InventoryList_dataGridView.SelectedRows.Count > 0) //выбрана ли строка для редактирования
            {
                Inventory selectedInventory = InventoryList_dataGridView.SelectedRows[0].DataBoundItem as Inventory; //получаем выбранную строку

                InventoryManager inventoryManager = new InventoryManager(SqlInventoryManager, SqlWriteOffManager);
                WriteOffInventoryForm writeOffInventoryForm = new WriteOffInventoryForm(inventoryManager, selectedInventory);
                if (writeOffInventoryForm.ShowDialog() == DialogResult.OK) // если результат диалога ОК, то
                {
                    InventoryList_dataGridView.DataSource = SqlInventoryManager.GetInventories();
                }
            }
            else
            {
                MessageBox.Show("Выберите инвентарь для списания", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Archive_button_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveForm = new ArchiveForm(); //открываем форму архив
            archiveForm.back_button.Visible = true;
            archiveForm.ShowDialog();
        }
    }
}
