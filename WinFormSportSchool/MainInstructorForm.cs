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
    public partial class MainInstructorForm: Form
    {
        SQLInstructorManager instructorManager = new SQLInstructorManager();
        public MainInstructorForm()
        {
            InitializeComponent();
        }

        private void MainInstructorForm_Load(object sender, EventArgs e)
        {
            try
            {
                InstructorsList_dataGridView.DataSource = instructorManager.GetInstructors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddInstructor_toolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
