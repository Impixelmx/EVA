using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public abstract class Respository
    {
        private readonly string connectionString;
        public Respository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Eva.Properties.Settings.EVA"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
