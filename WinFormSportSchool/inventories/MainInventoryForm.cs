using SportSchoolLib;
using SportSchoolLib.Inventors;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ArchiveForm archiveForm = new ArchiveForm();
            Hide();
            if(archiveForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
