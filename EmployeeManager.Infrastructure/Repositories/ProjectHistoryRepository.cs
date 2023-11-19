using EmployeeManager.Domain.Interfaces;
using EmployeeManager.Domain.Models;
using EmployeeManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Infrastructure.Repositories;

public class ProjectHistoryRepository:IProjectHistoryRepository
{
    private readonly ContextDb _context;

    public ProjectHistoryRepository(ContextDb context)
    {
        _context = context;
    }

    public async Task<List<EmployeeProjectHistory>> GetAllProjectsForEmployee(int employeeId)
    {
        return await _context.EmployeeProjectHistories.Where(x => x.EmployeeId == employeeId).ToListAsync();
    }

    public async Task<List<EmployeeProjectHistory>> GetAllEmployeesForProject(int projectId)
    {
        return await _context.EmployeeProjectHistories.Where(x => x.ProjectId == projectId).ToListAsync();
    }

    public Task AddProjectToEmployee()
    {
        throw new NotImplementedException();
    }
}