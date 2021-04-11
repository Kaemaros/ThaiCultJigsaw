using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jigsaw01
{
    public partial class form_Menu : Form
    {
        public form_Menu()
        {
            InitializeComponent();
        }

        private void btn_menuSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change to StageSelet");
            this.Hide();
            //new form_StageSelet().Show();
        }

        private void btn_menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change to StageSelet");
            this.Hide();
            new form_AboutUs().Show();
        }

        private void btn_menuScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change to StageSelet");
            this.Hide();
            new form_Score().Show();
        }

        private void btn_menuExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
