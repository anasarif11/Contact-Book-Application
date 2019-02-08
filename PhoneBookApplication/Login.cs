using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userName.Text == "admin" && password.Text=="admin")
            {
                contactdetailfom f1 = new contactdetailfom();
                this.Hide();
                f1.Show();
            }
            else
                MessageBox.Show("Please Check Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
