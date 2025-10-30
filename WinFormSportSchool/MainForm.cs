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
    public partial class MainForm : Form
    {
        MySQLTraineeManager traineeManager = new MySQLTraineeManager();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                tableListTrainees_dataGridView.DataSource = traineeManager.GetListTrainee();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTrainee_button_Click(object sender, EventArgs e)
        {
            TraineeDBManager traineeDBManager = new TraineeDBManager(traineeManager);
            AddTraineeForm addTraineeForm = new AddTraineeForm(traineeDBManager);
            if (addTraineeForm.ShowDialog() == DialogResult.OK)
            {
                tableListTrainees_dataGridView.DataSource = traineeManager.GetListTrainee();
            }
        }

    }
}
