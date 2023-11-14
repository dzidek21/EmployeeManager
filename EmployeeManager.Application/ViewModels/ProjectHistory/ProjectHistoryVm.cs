using EmployeeManager.Application.ViewModels.Employee;
using EmployeeManager.Application.ViewModels.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Application.ViewModels.ProjectHistory
{
    public class ProjectHistoryVm
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeVm? Employee { get; set; }
        public int ProjectId { get; set; }
        public ProjectVm? Project { get; set; }
    }
}
