using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using subventions.Controllers;

namespace subventions
{
    public partial class ChangePayment : Form
    {
        string pay_id = "";
        public ChangePayment(DataGridViewCellCollection id)
        {
            InitializeComponent();
            //MessageBox.Show((string)id[0].Value);
            DataTable dataForDGV = new ControllerAddOrEdit().getPayment(int.Parse((string)id[0].Value));

            pay_id = dataForDGV.Rows[0][0].ToString();
            textBox1.Text = dataForDGV.Rows[0][1].ToString();
            dateTimePicker1.Value = DateTime.Parse(dataForDGV.Rows[0][2].ToString());
        }

        private void change_pay_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");

            string amount = textBox1.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            string id = pay_id;

            conn.Open();
                NpgsqlCommand change_pay = new NpgsqlCommand("update payment set amount = " + amount + ", pay_date = '" + date + "' where pay_id = " + id, conn);
                change_pay.ExecuteNonQuery();
                MessageBox.Show("Изменение прошло успешно!");
            conn.Close();

            Close();
        }
    }
}
