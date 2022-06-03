using subventions.DataBaseNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace subventions.Controllers
{
    class RegistrationController
    {
        public string message = "";
        public string Enter(string login, string fio, string password)
        {
            if (fio.Length < 3)
            {
                message = "Введите имя";
                return message;
            }
            if (login.Length < 3)
            {
                message = "Слишком короткий логин";
                return message;
            }
            if (password.Length < 5)
            {
                message = "Слишком лёгкий пароль, должно быть 5 символов";
                return message;
            }
            else
            {
                _ = new DataBase($"INSERT INTO users(login, password, fullname, role_id, org_id) VALUES('{login}', '{password}', '{fio}', 0, 0); ");
                message = "";
                return message;
            }
        }
    }
}
