using EmployeeManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Domain.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllProjects();
        Task AddNewProject(Project newProject);
        Task<Project> GetProjectById(int id);
    }
}
