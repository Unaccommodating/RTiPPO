using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subventions.DataBaseAzat
{
    class DataBaseAzat
    {
        public DataTable data = new DataTable();

        public DataBaseAzat(string request)
        {
            NpgsqlConnection connector = new NpgsqlConnection("Server=localhost;Port=5432;Database=subventions;User Id=postgres;Password=postgres;");
            connector.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connector;
            command.CommandType = CommandType.Text;
            command.CommandText = request;

            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                data = dataTable;
            }
            command.Dispose();
            connector.Close();
        }
    }
}
