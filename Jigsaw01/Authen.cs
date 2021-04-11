using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jigsaw01
{
    class Authen
    {
        public Authen(string name) {
            MessageBox.Show("Using Authen From " + name);
        }
        public string username,password;
        string u1 = "123", p1 = "456"; //Update Again After Finish DATABASE
        string u2, p2; //Update Again After Finish DATABASE


        public bool Login(String username,String password)
        {
            MessageBox.Show("U1,U2,P1,P2 = " + u1 + " " + u2 + " " + p1 + " " + p2);
            if ((username.Equals(u1) || username.Equals(u2)) && (password.Equals(p1) || password.Equals(p2))) //Update Again After Finish DATABASE 
            { 
                this.username = username;
                this.password = password;
                MessageBox.Show("True");
                return true;
            }
            MessageBox.Show("False");
            return false;
        }

        public bool Register(String username, String password) //Update Again After Finish DATABASE
        { 
            if (!username.Equals(u1)) //Update Again After Finish DATABASE
            { 
                MessageBox.Show("ADD to DB"); //Update Again After Finish DATABASE
                this.u2 = username; //Update Again After Finish DATABASE
                this.p2 = password; //Update Again After Finish DATABASE
                return true;
            }
            return false;
        }
    }
}
