using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using subventions.DataBaseRoma;

namespace models.Users
{
	public class Users
	{
		public string login;
		private int role;
		private int organization;
		private string password;
		private string fullname;

		public Users(string login)
		{
			DataBaseRoma DB = new DataBaseRoma($"SELECT * FROM users WHERE login='{login}'");

			Login = (string)DB.data.Rows[0]["login"];
			Role = (int)DB.data.Rows[0]["role_id"];
			Organization = (int)DB.data.Rows[0]["org_id"];
			Password = (string)DB.data.Rows[0]["password"];
			Fullname = (string)DB.data.Rows[0]["fullname"];
		}
		public string Login { get => login; set => login = value; }
		public int Role { get => role; set => role = value; }
		public int Organization { get => organization; set => organization = value; }
		public string Password { get => password; set => password = value; }
		public string Fullname { get => fullname; set => fullname = value; }
	}
}