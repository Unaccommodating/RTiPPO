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

namespace subventions
{
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");

            conn.Open();
            NpgsqlCommand sub_comm = new NpgsqlCommand("select count(*) from subvention", conn);
            NpgsqlCommand pay_comm = new NpgsqlCommand("select count(*) from payment", conn);

            Int64 sub_count = (Int64)sub_comm.ExecuteScalar();
            Int64 pay_count = (Int64)pay_comm.ExecuteScalar();
            conn.Close();
            /*
            string sub_id = sub_count.ToString();
            string pay_id = pay_count.ToString();
            string tak = AddTaker.SelectedValue.ToString();
            string giv = AddGiver.SelectedValue.ToString();
            string yr = AddYear.Value.ToShortDateString();
            string amount = AddAmount.Text;
            string date = AddDate.Value.ToShortDateString();

            
            conn.Open();
            NpgsqlCommand sub_insert = new NpgsqlCommand("insert into subvention values(" + sub_id + "," + giv + ",'" + yr + "'," + tak + ")", conn);
            NpgsqlCommand pay_insert = new NpgsqlCommand("insert into payment values(" + pay_id + "," + sub_id + "," + amount + ",'" + date + "')", conn);
            sub_insert.ExecuteNonQuery();
            pay_insert.ExecuteNonQuery();
            MessageBox.Show("Добавление прошло успешно!");
            */
            conn.Close();

            Close();
        }
    }
}
