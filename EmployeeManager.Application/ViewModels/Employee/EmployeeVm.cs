using EmployeeManager.Application.ViewModels.Project;
using EmployeeManager.Application.ViewModels.ProjectHistory;

namespace EmployeeManager.Application.ViewModels.Employee
{
    public class EmployeeVm
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CurrentProjectId { get; set; }
        public ProjectVm? CurrentProject { get; set; }
        public List<ProjectHistoryVm> ProjectsHistory { get; set; } = new List<ProjectHistoryVm>();
    }
}
