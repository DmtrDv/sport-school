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

        private void AddInventory_toolStripButton_Click(object sender, EventArgs e)
        {
            InventoryManager inventoryManager = new InventoryManager(SqlInventoryManager);
            AddInventoryForm addInventoryForm = new AddInventoryForm(inventoryManager);
            if (addInventoryForm.ShowDialog() == DialogResult.OK)
            {
                InventoryList_dataGridView.DataSource = SqlInventoryManager.GetInventories();
            }
        }
    }
}
