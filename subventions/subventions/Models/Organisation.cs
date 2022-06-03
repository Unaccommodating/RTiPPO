using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using subventions.DataBaseRoma;

namespace models.Organization
{
	class Organisation
	{
		private int id;
		private string name;
		private string legal_adress;
		private int distr_id;
		private int org_type;

		public Organisation(int id)
		{
			DataBaseRoma DB = new DataBaseRoma(request: $"SELECT * FROM organisation WHERE org_id={id}");

			Id = (int)DB.data.Rows[0]["org_id"];
			Distr_id = (int)DB.data.Rows[0]["distr_id"];
			Org_type = (int)DB.data.Rows[0]["org_type"];
			Name = (string)DB.data.Rows[0]["org_name"];
			Legal_adress = (string)DB.data.Rows[0]["legal_adress"];
		}

		public List<Organisation> Enumeration(int id)
		{
			DataBaseRoma DB = new DataBaseRoma(request: $"SELECT * FROM organisation WHERE distr_id={id}");
			DataTable input = DB.data;
			List<Organisation> output = new List<Organisation>();
			DataRow[] rows = input.Select();
			foreach (DataRow row in rows)
			{
				output.Add(new Organisation(Convert.ToInt32(row["org_id"])));
			}
			return output;
		}

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Legal_adress { get => legal_adress; set => legal_adress = value; }
		public int Distr_id { get => distr_id; set => distr_id = value; }
		public int Org_type { get => org_type; set => org_type = value; }
	}
}