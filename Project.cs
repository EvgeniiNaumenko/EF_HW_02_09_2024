using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_02_09_2024
{
    internal class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
