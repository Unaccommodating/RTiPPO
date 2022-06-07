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
using models.Users;

namespace subventions
{
    public partial class Registry : Form
    {
        string[] sort = new string[2]; 
        string[] filter = new string[2] { "", "organisation1" };
        private Users user;
        public int pageNow = 1;
        public Registry(Users user)
        {
            InitializeComponent();
            this.user = user;
            FillDataGridWithSubv();
        }

        private void FillDataGridWithSubv()
        {
            DataTable subventions = new ControllerRegistry().Records(pageNow, user);

            DataSet table = new DataSet();

            table.Tables.Add(subventions);

            DataGridView DGV = dataGridView1;
            DGV.Columns.Clear();
            DGV.DataSource = table.Tables[0];
            DGV.Columns["id"].Visible = false;
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
            List<int> subvention_id = new List<int>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                subvention_id.Add(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["id"].Value));
            }
            Delete.DeleteSubvention(subvention_id);
            FillDataGridWithSubv();

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
            //ChangeForm form = new ChangeForm();
            //form.Show();
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

                DataTable subventions = new ControllerRegistry().Records(pageNow, user);

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
            DataTable subventions = new ControllerRegistry().Records(pageNow+1, user);
            
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

        private void Registry_Load(object sender, EventArgs e)
        {
            nameLabel.Text = "Добро пожаловать, " + user.Fullname;
            if (user.Role != 2)
            {
                buttonDelete.Hide();
            }
            else
            {
                buttonDelete.Show();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void МО_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            user = null;
            this.Hide();
            Welcome form = new Welcome();
            form.Show();
        }
    }
}
