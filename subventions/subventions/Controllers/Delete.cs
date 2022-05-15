using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subventions.Controllers
{
    class Delete
    {
        public bool DeleteSubvention(int subv_id)
        {
            if (subv_id != 0)
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
