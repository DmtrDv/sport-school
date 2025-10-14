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
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddTrainee_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы могли бы добавить ученика, но, к сожалению, не сегодня");
        }
    }
}
