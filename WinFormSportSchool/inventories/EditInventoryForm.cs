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
    public partial class EditInventoryForm: Form
    {
        private InventoryManager inventoryManager_;
        private Inventory editingInventory_;
        public EditInventoryForm(InventoryManager manager, Inventory inventory)
        {
            InitializeComponent();
            inventoryManager_ = manager;
            editingInventory_ = inventory;

            Name_textBox.Text = editingInventory_.Name_Inventory;
            Count_numericUpDown.Value = editingInventory_.Count_Inventory;
            DateDelivery_dateTimePicker.Value = editingInventory_.DateDelivery; //получение данных в форму 
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            editingInventory_.Name_Inventory = Name_textBox.Text.Trim();
            editingInventory_.Count_Inventory = (int)Count_numericUpDown.Value;
            editingInventory_.DateDelivery = DateDelivery_dateTimePicker.Value; //получение данных из формы

            string res = inventoryManager_.UpdateInventory(editingInventory_); //если результат корректный, то сохраняем его и передаём значение DialogResult == OK
            if (res == "Запись успешно обновлена")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(res, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e) // отмена действий
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
