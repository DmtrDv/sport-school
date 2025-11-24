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
    public partial class WriteOffInventoryForm: Form
    {
        private InventoryManager inventoryManager_;
        private Inventory selectedInventory_;
        public WriteOffInventoryForm(InventoryManager inventoryManager, Inventory selectedInventory)
        {
            InitializeComponent();
            inventoryManager_ = inventoryManager;
            selectedInventory_ = selectedInventory;

            Name_label.Text = selectedInventory_.Name_Inventory;
            dateWriteOff_dateTimePicker.Value = DateTime.Now;
        }

        private void writtenOff_button_Click(object sender, EventArgs e)
        {
            int writeOffCount = (int)count_numericUpDown.Value;

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите списать {writeOffCount} единиц инвентаря {selectedInventory_.Name_Inventory}?",
                "Подтверждение списания", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // cписываем
                string writeOffResult = inventoryManager_.WriteOffInventory(selectedInventory_, writeOffCount);

                if (writeOffResult == "Инвентарь успешно списан")
                {
                    MessageBox.Show(writeOffResult, "Сообщение",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(writeOffResult, "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
