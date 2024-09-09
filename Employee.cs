using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_02_09_2024
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<Project> Projects { get; set; }
    }
}
