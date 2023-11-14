using EmployeeManager.Application.ViewModels.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Application.Interfaces
{
    public interface IProjectService
    {
        Task<List<ProjectVm>> GetAllProjects();
        Task AddNewProject(ProjectVm newProject);
        Task <ProjectVm> GetProjectById(int id);
    }
}
