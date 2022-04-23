using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subventions.Controllers
{
    class Registration
    {
        public bool Enter(string login, string FIO, string password)
        {
            if (login != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
