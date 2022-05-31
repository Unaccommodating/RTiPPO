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
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<<< HEAD:subventions/Registry.cs
            Record form = new Record();
            form.ShowDialog();
========
            this.Hide();
            Form3 form = new Form3();
            form.Show();
>>>>>>>> Rassim:subventions/Form1.cs
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

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
        }
    }
}
