using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;
using models.Organization;
using models.Subvention;
using models.district;
using models.Payment;
using System.Windows.Forms;
using System.Data;

namespace subventions.Controllers{
	class ControllerRegistry
    {
        DataTable data = new DataTable();
        private const int posts = 2;
        private static int page = 1;


        public DataTable Records(int pageNow)
        {
            var iter = 0;
            page = pageNow;
            data.Columns.Add("id");
            data.Columns.Add("Муниципальное образование");
            data.Columns.Add("Получатель");
            data.Columns.Add("Распределитель");
            data.Columns.Add("Год", typeof(DateTime));
            data.Columns.Add("Сумма");

            models.Users.Users user = new models.Users.Users("admin");
            Organisation organisation = new Organisation(user.Organization);
            MunicipalDistrict districtName = new MunicipalDistrict(organisation.Distr_id);
            List<Organisation> organisationsList = organisation.Enumeration(organisation.Distr_id);
            List<Subvention> subventionsList = new List<Subvention>();
            foreach (var org in organisationsList)
            {
                subventionsList.AddRange(Subvention.Enumeration(org.Id));
            }
            foreach (var subv in subventionsList)
            {
                if((iter < posts*page) && (iter >= posts * (page-1)))
                    data.Rows.Add(subv.id, districtName.Name, new Organisation(subv.Recipient).Name, new Organisation(subv.Destributor).Name, subv.Year, subv.Sum);
                iter += 1;
            }

            return data;
        }
        public DataTable Records(string[] paramsSort, string[] paramsFilter)
        {
            DataView sorted = new DataView(data);
            MessageBox.Show($"{data.Columns[2].ColumnName}");
            sorted.Sort = "Получатель";
            data = sorted.ToTable();

            return data;
        }
        public bool checkAccess(int id)
        {
            return true;
        }
        public DataTable OpenRecordDGV(int id)
        {
            DataTable subvention = new DataTable();
            subvention.Columns.Add("id");
            subvention.Columns.Add("Объём выданных ден. средств");
            subvention.Columns.Add("Дата");

            List<Payment> payments = Payment.Enumeration(id);
            foreach (var payment in payments)
            {
                subvention.Rows.Add(payment.Id, payment.Amount, payment.Pay_date);

            }

            return subvention;
        }
        public DataTable OpenRecordInputs(DataGridViewCellCollection cell)
        {
            DataTable subvention = new DataTable();
            subvention.Columns.Add("District");
            subvention.Columns.Add("distrubutor");
            subvention.Columns.Add("recipient");
            subvention.Columns.Add("year");
            
            subvention.Rows.Add(((string)cell[1].Value), ((string)cell[2].Value), ((string)cell[3].Value), (cell[4].Value).ToString());
            
            return subvention;
        }


        public bool exportExcel()
        {
            return true;
        }
    }
}