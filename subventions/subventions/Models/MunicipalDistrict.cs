using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using subventions.DataBaseRoma;

namespace models.district
{ 
    class MunicipalDistrict
    {
        private int id;
        private string name;
	    public MunicipalDistrict(int id){
            DataBaseRoma DB = new DataBaseRoma(request: $"SELECT * FROM MunicipalDistrict WHERE distr_id={id}");

            Name = (string)DB.data.Rows[0]["distr_name"];
            Id = (int)DB.data.Rows[0]["distr_id"];
        }

        public Dictionary<long, string> Enumeration(DataTable input)
        {
            Dictionary<long, string> output = new Dictionary<long, string>();
            DataRow[] rows = input.Select();
            for (int i = 0; i < rows.Length; i++)
                output[i] = (string)rows[i]["distr_name"];
            return output;
        }

        public int Id { get => id; set => id = value; }

	    public string Name { get => name; set => name = value; }
    }
}