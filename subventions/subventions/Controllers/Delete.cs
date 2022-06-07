using subventions.DataBaseNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subventions.Controllers
{
    static class Delete
    {
        public static bool DeleteSubvention(List<int> subv_id)
        {
            try
            {
                foreach (var item in subv_id)
                {
                    string sqlReq = $"DELETE FROM public.\"Subvention\" WHERE subv_id = {item}";
                    DataBase DB = new DataBase(sqlReq);
                }
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }
}
