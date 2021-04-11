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
    public partial class form_Register : Form
    {
        Authen auth = new Authen("form_Register");
        public form_Register()
        {
            MessageBox.Show("form_Register Init");
            InitializeComponent();
        }

        private void btn_regRegister_Click(object sender, EventArgs e)
        {
            if (txt_regConPassword.Text.Equals(txt_regPassword.Text) && auth.Register(txt_regUsername.Text, txt_regPassword.Text))
            {
                MessageBox.Show("Register Successfully");
                this.Hide();
                new form_Login().Show();
            }
            else {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_regBack_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            new form_Login().Show();
        }
    }
}
