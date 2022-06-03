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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");

            conn.Open();
                DataTable dt_mun = new DataTable();
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM municipaldistrict", conn);
                adap.Fill(dt_mun);
                AddMun.DataSource = dt_mun;
                AddMun.DisplayMember = "distr_name";
                AddMun.ValueMember = "distr_id";
            conn.Close();

            AddMun.SelectedIndex = -1;
        }

        private void AddMun_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");
            
            conn.Open();
                DataTable dt_taker = new DataTable();
                NpgsqlDataAdapter adap1 = new NpgsqlDataAdapter("SELECT * FROM organisation where distr_id=" + AddMun.SelectedIndex.ToString(), conn);
                adap1.Fill(dt_taker);
                AddTaker.DataSource = dt_taker;
                AddTaker.ValueMember = "org_id";
                AddTaker.DisplayMember = "org_name";
            
                DataTable dt_giver = new DataTable();
                NpgsqlDataAdapter adap2 = new NpgsqlDataAdapter("SELECT * FROM organisation where org_type = 1 and distr_id=" + AddMun.SelectedIndex.ToString(), conn);
                adap2.Fill(dt_giver);
                AddGiver.DataSource = dt_giver;
                AddGiver.DisplayMember = "org_name";
                AddGiver.ValueMember = "org_id";
            conn.Close();

            AddTaker.SelectedIndex = -1;
            AddGiver.SelectedIndex = -1;
        }

        private void AddCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");

            conn.Open();
                NpgsqlCommand sub_comm = new NpgsqlCommand("select count(*) from subvention", conn);
                NpgsqlCommand pay_comm = new NpgsqlCommand("select count(*) from payment", conn);
                Int64 sub_count = (Int64)sub_comm.ExecuteScalar();
                Int64 pay_count = (Int64)pay_comm.ExecuteScalar();
            conn.Close();

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
            conn.Close();

            Close();
        }
    }
}
