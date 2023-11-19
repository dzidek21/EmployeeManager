using EmployeeManager.Domain.Models;

namespace EmployeeManager.Domain.Interfaces;

public interface IProjectHistoryRepository
{
    Task<List<EmployeeProjectHistory>> GetAllProjectsForEmployee(int employeeId);
    Task<List<EmployeeProjectHistory>> GetAllEmployeesForProject(int projectId);
    Task AddProjectToEmployee();
}