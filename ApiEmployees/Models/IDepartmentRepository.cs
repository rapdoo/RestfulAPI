﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmployees.Models
{
    public interface IDepartmentRepository
    {
        List<Department> GetDepartment();
    }
}
