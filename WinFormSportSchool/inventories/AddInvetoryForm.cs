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
    public partial class AddInvetoryForm: Form
    {
        private InventoryManager inventoryManager_;
        public AddInvetoryForm(InventoryManager inventoryManager)
        {
            InitializeComponent();
            inventoryManager_ = inventoryManager;
            

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory()
            {
                Name_Inventory = Name_textBox.Text.Trim(),
                Count_Inventory = (int)Count_numericUpDown.Value,
                DateDelivery = DateDelivery_dateTimePicker.Value
            };
            string res = inventoryManager_.AddInventory(inventory);
            if (res == "Новая запись успешно добавлена")
            {
                MessageBox.Show(res, "Сообщение",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(res, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
