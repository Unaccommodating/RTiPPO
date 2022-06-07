using subventions.DataBaseNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subventions.Controllers
{
    class AuthController
    {
        public string message = "";
        public string Enter(string login, string password)
        {
            try
            {
                DataBase DB = new DataBase($"SELECT login, password FROM users WHERE login='{login}' AND password='{password}'");
                string loginAnswer = (string)DB.data.Rows[0]["login"];
                string passwordAnswer = (string)DB.data.Rows[0]["password"];
                return message;
            }
            catch (IndexOutOfRangeException)
            {
                string message = "Такой пользователь не найден!\nПроверьте логин и пароль\nили зарегестрируйтесь.";
                return message;
            }
        }
    }
}
