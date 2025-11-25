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

namespace WinFormSportSchool
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void trainee_button_Click(object sender, EventArgs e)
        {
            MainTraineeForm mainTraineeForm = new MainTraineeForm();
            //Hide();
            if (mainTraineeForm.ShowDialog() == DialogResult.OK)
            {
               // this.Show();
            }
        }

        private void instructor_button_Click(object sender, EventArgs e)
        {
            MainInstructorForm mainInstructorForm = new MainInstructorForm();
           // Hide();
            if (mainInstructorForm.ShowDialog() == DialogResult.OK)
            {
              //  this.Show();
            }
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            MainInventoryForm mainInventoryForm = new MainInventoryForm();
            //Hide();
            if (mainInventoryForm.ShowDialog() == DialogResult.OK)
            {
               // this.Show();
            }
        }

        private void archive_button_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveForm = new ArchiveForm();
            Hide();
            if (archiveForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
