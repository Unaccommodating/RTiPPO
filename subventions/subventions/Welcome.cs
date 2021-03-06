using models.Users;
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
    public partial class Welcome : Form
    {
        private string login;
        private string password;
        AuthController authControllers = new AuthController();

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
            password = md5.hashPassword(passwordTextBox.Text);
            string answer = authControllers.Enter(login, password);
            if (answer != "")
            {
                MessageBox.Show(answer);
            }
            else
            {
                var user = new Users(login);
                this.Hide();
                Registry form = new Registry(user);
                form.Show();
                
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration form = new Registration();
            form.Show();
        }
    }
}
