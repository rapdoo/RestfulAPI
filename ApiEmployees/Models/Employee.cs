using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmployees.Models
{
    public class Employee
    {
        public int Emp_No { get; set; }
        public DateTime Birth_Date { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public char Gender { get; set; }
        public DateTime Hire_Date { get; set; }
    }
}
