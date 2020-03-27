using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

using ApiEmployees.Models;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace ApiEmployees.Repositories
{
    public class EmployeeServiceRepository
    {
        IConfiguration _config;
        MySqlConnection db;

        public EmployeeServiceRepository(IConfiguration config)
        {
            _config = config;

            db = new MySqlConnection(_config.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
        }
    }
}
