using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_02_09_2024
{
    internal class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
