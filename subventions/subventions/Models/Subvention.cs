using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using subventions.DataBaseAzat;
using models.Payment;

namespace models.Subvention
{
	public class Subvention
	{
		public int id;
		private int destributor;
		private int recipient;
		private DateTime year;
		private int sum;

		public Subvention(int id)
		{
			DataBaseAzat DB = new DataBaseAzat(request: $"SELECT * FROM subvention WHERE subv_id={id}");

			Destributor = (int)DB.data.Rows[0]["distributor"];
			Recipient = (int)DB.data.Rows[0]["recipient"];
			Year = (DateTime)DB.data.Rows[0]["year"];
			Id = (int)DB.data.Rows[0]["subv_id"];
			List<Payment.Payment> paymentsList = Payment.Payment.Enumeration(Id);
			foreach (var payment in paymentsList)
			{
			//	MessageBox.Show($"payment - {payment.Amount}, id - {payment.Id}, subv - {payment.Subvention}");
				Sum += payment.Amount;
			//	MessageBox.Show($"sum - {Sum}");
			}
		}

		public static List<Subvention> Enumeration(int id)
		{
			DataBaseAzat DB = new DataBaseAzat(request: $"SELECT * FROM subvention WHERE recipient={id}");
			DataTable input = DB.data;
			List<Subvention> output = new List<Subvention>();
			DataRow[] rows = input.Select();
			foreach (DataRow row in rows)
			{
				output.Add(new Subvention(Convert.ToInt32(row["subv_id"])));
			}
			return output;
		}

		public static List<Subvention> filter(string column, string text)
		{
			DataBaseAzat DB = new DataBaseAzat(request: $"SELECT * FROM subvention WHERE {column}={text}");
			DataTable input = DB.data;
			List<Subvention> output = new List<Subvention>();
			DataRow[] rows = input.Select();
			foreach (DataRow row in rows)
			{
				output.Add(new Subvention(Convert.ToInt32(row["subv_id"])));
			}
			return output;
		}

		//	public Dictionary<> fillData

		public int Id { get => id; set => id = value; }
		public int Destributor { get => destributor; set => destributor = value; }
		public int Recipient { get => recipient; set => recipient = value; }
		public DateTime Year { get => year; set => year = value; }
		public int Sum { get => sum; set => sum = value; }
	}
}