using EmployeeManager.Application.ViewModels.ProjectHistory;

namespace EmployeeManager.Application.Interfaces;

public interface IProjectHistoryService
{
    Task<List<ProjectHistoryVm>> GetAllProjectsForEmployee(int employeeId);
    Task<List<ProjectHistoryVm>> GetAllEmployeesForProject(int projectId);
    
}