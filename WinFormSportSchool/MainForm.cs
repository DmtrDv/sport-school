using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormSportSchool.inventories;
using WinFormSportSchool.reports;

namespace WinFormSportSchool
{
    public partial class MainForm: Form
    {
        private Form currentForm = null;
        public MainForm()
        {
            InitializeComponent();
            FindOf_textBox.TextChanged += FindOf_textBox_TextChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void trainee_button_Click(object sender, EventArgs e)
        {
            ShowFormInWorkArea(new MainTraineeForm());
        }

        private void instructor_button_Click(object sender, EventArgs e)
        {
            ShowFormInWorkArea(new MainInstructorForm());
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            ShowFormInWorkArea(new MainInventoryForm());
        }

        private void archive_button_Click(object sender, EventArgs e)
        {
            ShowFormInWorkArea(new ArchiveForm());
        }
        private void ClearWindows_button_Click(object sender, EventArgs e)
        {
            this.workArea_panel.Controls.Clear();
            currentForm = null;
            FindOf_label.Enabled = false;
            FindOf_textBox.Enabled = false;
            this.Text = "Спортивная школа";
            FindOf_textBox.Text = "";
        }
        private void Report_button_Click(object sender, EventArgs e)
        {
            ShowFormInWorkArea(new ReportsForm());
            FindOf_label.Enabled = false;
            FindOf_textBox.Enabled = false;
        }
        private void FindOf_textBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = FindOf_textBox.Text.Trim();

            if (currentForm != null)
            {
                if (currentForm is MainInventoryForm inventoryForm) inventoryForm.SearchData(searchText);
                else if (currentForm is MainTraineeForm traineeForm) traineeForm.SearchData(searchText);
                else if (currentForm is MainInstructorForm instructorForm) instructorForm.SearchData(searchText);
                else if (currentForm is ArchiveForm archiveForm) archiveForm.SearchData(searchText);
            }
        }
        private void ShowFormInWorkArea(Form form)
        {
            // Закрыть текущую форму
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose(); //освобождает ресурсы
            }

            // Настраиваем новую форму
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;

            // Добавляем в рабочую область
            this.workArea_panel.Controls.Clear();
            this.workArea_panel.Controls.Add(form);

            currentForm = form;

            // Обновляем заголовок главного окна
            this.Text = "Спортивная школа - " + form.Text;
            
            FindOf_label.Enabled = true;
            FindOf_textBox.Enabled = true;
            FindOf_textBox.Text = "";

        }

        private void ClearSearch_button_Click(object sender, EventArgs e)
        {
            FindOf_textBox.Text = "";
        }

    }
}
