using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using subventions.Controllers;
using models.Subvention;


namespace subventions
{
    public partial class Registry : Form
    {
        string[] sort = new string[2]; 
        string[] filter = new string[2] { "", "organisation1" };

        public int pageNow = 1;
        public Registry()
        {
            InitializeComponent();
            DataTable subventions = new ControllerRegistry().Records(pageNow);

            DataSet table = new DataSet();
            
            table.Tables.Add(subventions);

            DataGridView DGV = dataGridView1;
            DGV.Columns.Clear();
            DGV.DataSource = table.Tables[0];
            DGV.Columns["id"].Visible = false;

            //    MessageBox.Show($"{subventions[0]}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable subventions = new ControllerRegistry().Records(sort, filter);

            DataSet table = new DataSet();

            table.Tables.Add(subventions);

            DataGridView DGV = dataGridView1;
            DGV.Columns.Clear();
            DGV.DataSource = table.Tables[0];
            DGV.Columns["id"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ToAddButton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Show();
        }

        private void ToChangeButton_Click(object sender, EventArgs e)
        {
            var subvention_id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells;
            ChangeForm form = new ChangeForm(subvention_id);
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var subvention_id = dataGridView1.Rows[e.RowIndex].Cells;
            Record form = new Record(subvention_id);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageNow > 1)
            {
                pageNow -= 1;

                DataTable subventions = new ControllerRegistry().Records(pageNow);

                DataSet table = new DataSet();

                table.Tables.Add(subventions);

                DataGridView DGV = dataGridView1;
                DGV.Columns.Clear();
                DGV.DataSource = table.Tables[0];
                DGV.Columns["id"].Visible = false;
            }
            else
                MessageBox.Show("Листать больше некуда");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable subventions = new ControllerRegistry().Records(pageNow+1);
            
            if (subventions.Rows.Count > 0)
            {
                pageNow += 1;

                DataSet table = new DataSet();

                table.Tables.Add(subventions);

                DataGridView DGV = dataGridView1;
                DGV.Columns.Clear();
                DGV.DataSource = table.Tables[0];
                DGV.Columns["id"].Visible = false;
            }
            else
                MessageBox.Show("Листать больше некуда");
        }
    }
}
