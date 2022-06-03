﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using subventions.DataBaseAzat;

namespace models.Payment
{
	public class Payment
	{
		private int id;
		private int subvention;
		private int amount;
		private DateTime pay_date;

		public Payment(int id)
		{
			DataBaseAzat DB = new DataBaseAzat(request: $"SELECT * FROM payment WHERE pay_id={id}");

			Id = (int)DB.data.Rows[0]["pay_id"];
			Subvention = (int)DB.data.Rows[0]["subv_id"];
			Amount = (int)DB.data.Rows[0]["amount"];
			Pay_date = (DateTime)DB.data.Rows[0]["pay_date"];
		}

		public static List<Payment> Enumeration(int id)
		{
			DataBaseAzat DB = new DataBaseAzat(request: $"SELECT * FROM payment WHERE subv_id={id}");
			DataTable input = DB.data;
			List<Payment> output = new List<Payment>();
			DataRow[] rows = input.Select();
			foreach (DataRow row in rows)
			{
				output.Add(new Payment(Convert.ToInt32(row["pay_id"])));
			}
			return output;
		}

		public int Id { get => id; set => id = value; }
		public int Subvention { get => subvention; set => subvention = value; }
		public int Amount { get => amount; set => amount = value; }
		public DateTime Pay_date { get => pay_date; set => pay_date = value; }
	}
}