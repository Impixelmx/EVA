using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
namespace DataAccess.Repositories
{
    public class PersonsRepository : MasterRepository, IPersonsRespository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public PersonsRepository()
        {
            selectAll= "SELECT * FROM table_name;";
            insert = "INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country) VALUES ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway'); ";
            update = "UPDATE Customers SET ContactName = 'Alfred Schmidt', City = 'Frankfurt' WHERE CustomerID = 1; ";
            delete = "DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';";
        }
        public Guid Add(Persons entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new)
        }

        public Guid Adit(Persons entity)
        {
             
        }

        public IEnumerable<Persons> GetAll()
        {
             
        }

        public Guid Remove(Guid IdPersona)
        {
            
        }
    }
}
