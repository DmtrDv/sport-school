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

        private void DeleteTrainee_Button_Click(object sender, EventArgs e)
        {
            if (tableListTrainees_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ученика для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Получаем ID выбранного ученика
            var selectedRow = tableListTrainees_dataGridView.SelectedRows[0];
            int traineeId = Convert.ToInt32(selectedRow.Cells["Id_Trainee"].Value);
            string traineeName = selectedRow.Cells["FIO"].Value.ToString();

            // Подтверждение удаления
            var result = MessageBox.Show($"Вы уверены, что хотите удалить учащегося?",
                "Подтверждение удаления",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                try
                {
                    // Создаем менеджер и выполняем удаление
                    TraineeDBManager traineeDBManager = new TraineeDBManager(traineeManager);

                    // Вызываем метод удаления
                    string deleteResult = traineeManager.DeleteTrainee(traineeId);

                    if (deleteResult == "Учащийся успешно удалён")
                    {
                        MessageBox.Show("Учащийся успешно удалён", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Обновляем список учащихся
                        tableListTrainees_dataGridView.DataSource = traineeManager.GetListTrainee();
                    }
                    else
                    {
                        MessageBox.Show(deleteResult, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении учащегося: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Пользователь отменил удаление
                MessageBox.Show("Удаление отменено", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
