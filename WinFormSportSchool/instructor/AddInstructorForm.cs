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
    public partial class AddInstructorForm: Form
    {
        private InstructorManager instructorManager_;
        public AddInstructorForm(InstructorManager instructorManager)
        {
            InitializeComponent();
            instructorManager_ = instructorManager;

            Qualification_comboBox.DataSource = Enum.GetValues(typeof(qualification));
            Qualification_comboBox.SelectedIndex = 0;
            Section_comboBox.DataSource = Enum.GetValues(typeof(section));
            Section_comboBox.SelectedIndex = 0;
            PhoneNumber_textBox.Mask = "+7(000)-000-00-00";
        }

        private void Add_Instructor_button_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor()
            {
                FIO_Instructor = FIO_textBox.Text.Trim(),
                Qualification = (qualification)Qualification_comboBox.SelectedItem,
                PhoneNumberInstructor = PhoneNumber_textBox.Text.Trim(),
                Section = (section)Section_comboBox.SelectedItem
            };
            string res = instructorManager_.AddInstructor(instructor);
            if (res == "Новый тренер успешно добавлен")
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
