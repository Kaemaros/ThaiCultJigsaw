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
    public partial class form_StageSelet : Form
    {
        string username;
        public form_StageSelet(string Username)
        {
            this.username = Username;
            InitializeComponent();
        }

        private void btn_seletS1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_StageN(this.username,1).Show();
        }

        private void btn_seletS2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_StageN(this.username, 2).Show();
        }

        private void btn_seletS3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_StageN(this.username, 3).Show();
        }
    }
}
