using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;
using ApiEmployees.Models;

namespace ApiEmployees.Repositories
{
    public class DepartmentServiceRepository : IDepartmentRepository
    {
        IConfiguration _config;
        MySqlConnection db;

        public DepartmentServiceRepository(IConfiguration config)
        {
            _config = config;

            db = new MySqlConnection(_config.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
        }

        public List<Department> GetDepartment()
        {
            string sql = "SELECT * FROM Deparments";

            return this.db.Query<Department>(sql).ToList();
        }
    }
}
