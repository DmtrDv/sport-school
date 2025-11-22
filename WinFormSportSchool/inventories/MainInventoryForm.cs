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

namespace WinFormSportSchool.inventories
{
    public partial class MainInventoryForm: Form
    {
        SQLInventoryManager SqlInventoryManager = new SQLInventoryManager();
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

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (InventoryList_dataGridView.SelectedRows.Count > 0)
            {
                Inventory selectedInventory = InventoryList_dataGridView.SelectedRows[0].DataBoundItem as Inventory;

                Inventory editingInventory = selectedInventory.Clone();
                InventoryManager inventoryManager = new InventoryManager(SqlInventoryManager);
                EditInventoryForm editInventoryForm = new EditInventoryForm(inventoryManager, editingInventory);
                if (editInventoryForm.ShowDialog() == DialogResult.OK)
                {
                    selectedInventory.Name_Inventory = editingInventory.Name_Inventory;
                    selectedInventory.Count_Inventory = editingInventory.Count_Inventory;
                    selectedInventory.DateDelivery = editingInventory.DateDelivery;
                }
            }
            else
            {
                MessageBox.Show("Выберите инвентарь для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
