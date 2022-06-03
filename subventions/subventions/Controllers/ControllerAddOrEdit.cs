using System;
using Npgsql;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Subvention;
using models.Payment;

class ControllerAddOrEdit
{
    string message = "";

    public string addRecord(Subvention record)
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");

        conn.Open();
        NpgsqlDataAdapter adap = new NpgsqlDataAdapter("update subvention set distributor  = " + record.Destributor + " and recipient =" + record.Recipient + " and year = " + record.Year + "where subv_id = " + record.id, conn);
        conn.Close();

        return message;
    }

    public string editRecord(Subvention record)
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");

        conn.Open();
        NpgsqlDataAdapter adap = new NpgsqlDataAdapter("update subvention set distributor  = "+ record.Destributor +" and recipient ="+ record.Recipient +" and year = "+ record.Year +"where subv_id = " + record.id, conn);
        conn.Close();

        return message;
    }

    public string addPayment(Payment payment)
    {
        return message;
    }

    public string editPayment(Payment payment)
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=12345;");

        conn.Open();
        NpgsqlDataAdapter adap = new NpgsqlDataAdapter("update payment set amount = " + payment.Amount + " and pay_date =" + payment.Pay_date + "where pay_id = " + payment.Id, conn);
        conn.Close();

        return message;
    }

    public List<Subvention> getRecord(int id)
    {
        List<Subvention> subventions = new List<Subvention>();
        return subventions;
    }

    public DataTable getPayment(int id)
    {
        DataTable subvention = new DataTable();
        subvention.Columns.Add("id");
        subvention.Columns.Add("Объём выданных ден. средств");
        subvention.Columns.Add("Дата");

        Payment payment = new Payment(id);
        subvention.Rows.Add(payment.Id, payment.Amount, payment.Pay_date);

        return subvention;
    }
}