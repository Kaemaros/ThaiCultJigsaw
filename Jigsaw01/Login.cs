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
    public partial class form_Login : Form
    {
        Authen auth = new Authen("form_Login");
        public form_Login()
        {
            MessageBox.Show("form_Login Init");
            InitializeComponent();
        }

        private void btn_logLogin_Click(object sender, EventArgs e)
        {
            if (this.auth.Login(txt_LoginUsername.Text, txt_LoginPassword.Text))
            {
                MessageBox.Show("Change to Menu");
                this.Hide();
                new form_Menu().Show();
            }
        }

        private void btn_logRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change to Register");
            this.Hide();
            new form_Register().Show();
        }

        private void btn_logExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
