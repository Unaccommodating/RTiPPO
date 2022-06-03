using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using subventions.Controllers;
using System.Windows.Forms;
using models.Subvention;

namespace subventions
{
    public partial class ChangeForm : Form
    {
        string id_sub = "";
        public ChangeForm(DataGridViewCellCollection id)
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");
            conn.Open();

                DataTable dt_mun = new DataTable();
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM municipaldistrict", conn);
                adap.Fill(dt_mun);
                ChangeMun.DataSource = dt_mun;
                ChangeMun.DisplayMember = "distr_name";
                ChangeMun.ValueMember = "distr_id";

            conn.Close();

            DataTable dataForDGV = new ControllerRegistry().OpenRecordDGV(int.Parse((string)id[0].Value));
            id_sub = dataForDGV.Rows[0]["id"].ToString();

            DataSet table = new DataSet();
            table.Tables.Add(dataForDGV);

            DataGridView DGV = dataGridView1;
            DGV.Columns.Clear();
            DGV.DataSource = table.Tables[0];
            DGV.Columns["id"].Visible = false;

            DataTable dataForInputs = new ControllerRegistry().OpenRecordInputs(id);

            ChangeMun.Text = (string)dataForInputs.Rows[0]["District"];
            ChangeTaker.Text = (string)dataForInputs.Rows[0]["distrubutor"];
            ChangeGiver.Text = (string)dataForInputs.Rows[0]["recipient"];
            ChangeYear.Text = dataForInputs.Rows[0]["year"].ToString();
        }

        private void ChangeMun_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");
            conn.Open();

            DataTable dt_taker = new DataTable();
            NpgsqlDataAdapter adap1 = new NpgsqlDataAdapter("SELECT * FROM organisation where distr_id=" + ChangeMun.SelectedIndex.ToString(), conn);
            adap1.Fill(dt_taker);
            ChangeTaker.DataSource = dt_taker;
            ChangeTaker.ValueMember = "org_id";
            ChangeTaker.DisplayMember = "org_name";


            DataTable dt_giver = new DataTable();
            NpgsqlDataAdapter adap2 = new NpgsqlDataAdapter("SELECT * FROM organisation where distr_id=" + ChangeMun.SelectedIndex.ToString(), conn);
            adap2.Fill(dt_giver);
            ChangeGiver.DataSource = dt_giver;
            ChangeGiver.DisplayMember = "org_name";
            ChangeGiver.ValueMember = "org_id";

            conn.Close();

            ChangeTaker.SelectedIndex = -1;
            ChangeGiver.SelectedIndex = -1;
        }


        private void ChangeCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form_add_button_Click(object sender, EventArgs e)
        {
            AddPayment f = new AddPayment();
            f.Show();
        }

        private void form_change_button_Click(object sender, EventArgs e)
        {
            var payment_id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells;
            ChangePayment f = new ChangePayment(payment_id);
            f.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string taker = ChangeTaker.Text;
            string giver = ChangeGiver.Text;
            string year = ChangeYear.Text;
            MessageBox.Show(taker + '\n' + giver + '\n' + year + '\n' + id_sub);

            //Subvention m = new Subvention();
            //string message = new ControllerAddOrEdit().editRecord(m);
            Close();
        }
    }
}
