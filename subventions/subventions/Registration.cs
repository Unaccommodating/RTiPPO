using subventions.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subventions
{
    public partial class Registration : Form
    {
        private string fio;
        private string login;
        private string password;
        RegistrationController registrationController = new RegistrationController();
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome form = new Welcome();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            fio = fioTextBox.Text;
            login = loginTextBox.Text;
            password = md5.hashPassword(passwordTextBox.Text);
            string answer = registrationController.Enter(login, fio, password);
            if (answer == "")
            {
                this.Hide();
                Welcome form = new Welcome();
                form.Show();
            }
            else
            {
                MessageBox.Show(answer);
            }
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void fio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
