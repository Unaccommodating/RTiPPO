using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using subventions.DataBaseAzat;
using System.Diagnostics;
using subventions.DataBaseNameSpace;

namespace models.Users
{
	public class Users
	{
		private string login;
		private int role;
		private int organization;
		private string password;
		private string fullname;

		public Users(string login1)
		{
			DataBase DB = new DataBase($"SELECT * FROM users WHERE login='{login1}'");
			Login = (string)DB.data.Rows[0]["login"];
			Role = (int)DB.data.Rows[0]["role_id"];
			Organization = (int)DB.data.Rows[0]["org_id"];
			Fullname = (string)DB.data.Rows[0]["fullname"];
		}
		public string Login { get => login; set => login = value; }
		public int Role { get => role; set => role = value; }
		public int Organization { get => organization; set => organization = value; }
		public string Password { get => password; set => password = value; }
		public string Fullname { get => fullname; set => fullname = value; }
	}
}