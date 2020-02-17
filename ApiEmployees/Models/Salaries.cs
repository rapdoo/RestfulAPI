using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmployees.Models
{
    public class Salaries
    {
        public int Emp_No { get; set; }
        public int Salary { get; set; }
        public DateTime From_Date { get; set; }
        public DateTime To_Date { get; set; }
    }
}
