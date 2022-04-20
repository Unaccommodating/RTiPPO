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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

<<<<<<< HEAD
        private void button3_Click(object sender, EventArgs e)
        {

=======
        private void ToAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm form = new AddForm();
            form.Show();
        }

        private void ToChangeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeForm form = new ChangeForm();
            form.Show();
>>>>>>> 06d1151b35bcc96f6f8c283e3f8eb524f5bff073
        }
    }
}
