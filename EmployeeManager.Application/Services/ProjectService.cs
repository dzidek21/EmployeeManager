using AutoMapper;
using EmployeeManager.Application.Interfaces;
using EmployeeManager.Application.ViewModels.Project;
using EmployeeManager.Domain.Interfaces;
using EmployeeManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepo;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository projectRepo, IMapper mapper)
        {
            _projectRepo = projectRepo;
            _mapper = mapper;
        }

        public Task AddNewProject(ProjectVm newProject)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProjectVm>> GetAllProjects()
        {
            var projects = await _projectRepo.GetAllProjects();
            return _mapper.Map<List<Project>,List < ProjectVm >> (projects);
        }

        public async Task<ProjectVm> GetProjectById(int id)
        {
            var project = await _projectRepo.GetProjectById(id);
            return _mapper.Map<Project, ProjectVm>(project);
        }
    }
}
