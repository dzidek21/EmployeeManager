using AutoMapper;
using EmployeeManager.Application.Interfaces;
using EmployeeManager.Application.ViewModels.ProjectHistory;
using EmployeeManager.Domain.Interfaces;
using EmployeeManager.Domain.Models;

namespace EmployeeManager.Application.Services;

public class ProjectHistoryService:IProjectHistoryService
{
    private readonly IProjectHistoryRepository _projectHistoryRepository;
    private readonly IMapper _mapper;

    public ProjectHistoryService(IProjectHistoryRepository projectHistoryRepository, IMapper mapper)
    {
        _projectHistoryRepository = projectHistoryRepository;
        _mapper = mapper;
    }

    public async Task <List<ProjectHistoryVm>> GetAllProjectsForEmployee(int employeeId)
    {
        var projects = await _projectHistoryRepository.GetAllProjectsForEmployee(employeeId);
        var mappedList = _mapper.Map<List<EmployeeProjectHistory>, List<ProjectHistoryVm>>(projects);
        return mappedList;
    }

    public async Task<List<ProjectHistoryVm>> GetAllEmployeesForProject(int projectId)
    {
        var employees = await _projectHistoryRepository.GetAllEmployeesForProject(projectId);
        var mappedEmployess = _mapper.Map<List<EmployeeProjectHistory>, List<ProjectHistoryVm>>(employees);
        return mappedEmployess;
    }
}