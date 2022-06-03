using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using subventions.Controllers;
using System.Windows.Forms;

namespace subventions
{
    public partial class Record : Form
    {
        public Record(DataGridViewCellCollection id)
        {
            InitializeComponent();
            DataTable dataForDGV = new ControllerRegistry().OpenRecordDGV(int.Parse((string)id[0].Value));

            DataSet table = new DataSet();
            table.Tables.Add(dataForDGV);

            DataGridView DGV = dataGridView1;
            DGV.Columns.Clear();
            DGV.DataSource = table.Tables[0];
            DGV.Columns["id"].Visible = false;

        //    MessageBox.Show("here1");

            DataTable dataForInputs = new ControllerRegistry().OpenRecordInputs(id);

        //    MessageBox.Show("here2");

            textBox1.Text = (string)dataForInputs.Rows[0]["District"];
            textBox2.Text = (string)dataForInputs.Rows[0]["distrubutor"];
            textBox3.Text = (string)dataForInputs.Rows[0]["recipient"];
            textBox4.Text = dataForInputs.Rows[0]["year"].ToString();

        //    MessageBox.Show("here3");
            //            MessageBox.Show($"{id}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
