using customersApi.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace customersApi.Repositories
{
    public class CustomersRepository : IcustomersRepository
    {
        private MySQLConfiguration _connectionString;
      //  private readonly ILoggingManager _loggingManager;
        public CustomersRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        //    _loggingManager = loggingManager;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }


        public  async Task<IEnumerable<customers>> GetAllCustomers()
        {

            var db = dbConnection();
            var sql = @"CALL SP_getcustomers();";

            return await db.QueryAsync<customers>(sql, new { });
        }

        public async Task<bool> InsertCustomer(customers customer)
        {
            var db = dbConnection();
            var sql = @"
                INSERT INTO user(email, nombre, apellido, fecha) 
                VALUES (@Email, @Nombre, @Apellido, @Fecha) ";
                string fecha = customer.fecha.ToString("yyyy/MM/dd");
            

                 var result= await db.ExecuteAsync(sql, new { Email = customer.email, Nombre = customer.nombre, Apellido = customer.apellido, Fecha = fecha});

            return  result>0;
        }
    }
}
