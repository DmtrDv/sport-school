using MySqlX.XDevAPI.Common;
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
    public partial class AddTraineeForm: Form
    {
        private TraineeDBManager traineeDBManager;
        public Trainee NewTrainee { get; private set; }
        public AddTraineeForm(TraineeDBManager manager)
        {
            InitializeComponent();
            traineeDBManager = manager;
        
            Section_comboBox.DataSource = Enum.GetValues(typeof(section));
            Section_comboBox.SelectedIndex = -1;
            Category_comboBox.DataSource = Enum.GetValues(typeof(category));
            Category_comboBox.SelectedIndex = -1;
        
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Trainee NTrainee = new Trainee()
            {
                FIO = FIO_textBox.Text.Trim(),
                Birthday = DateBirthday_dateTimePicker.Value,
                Section = (section)Section_comboBox.SelectedItem,
                Category = (category)Category_comboBox.SelectedItem,
                FIOParent = FIOParent_textBox.Text.Trim(),
                PhoneNumberParent = PhoneNumberParent_textBox.Text.Trim()
            };
            string res = traineeDBManager.AddTrainee(NTrainee);
            if (res == "Ученик успешно добавлен")
            {
                NewTrainee = NTrainee;
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
