using EmployeeManager.Application.ViewModels.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Application.ViewModels.Project
{
    public class ProjectVm
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectNumber { get; set; }
        public List<EmployeeVm>? Employees { get; set; }
    }
}
