using EmployeeManager.Domain.Interfaces;
using EmployeeManager.Domain.Models;
using EmployeeManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ContextDb _context;

        public ProjectRepository(ContextDb context)
        {
            _context = context;
        }

        public Task AddNewProject(Project newProject)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Project>> GetAllProjects()
        {
            return await _context.Projects.Include(x=>x.Employees).ToListAsync();
        }

        public async Task<Project> GetProjectById(int id)
        {
            var proj= await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);
            _context.Entry(proj).State = EntityState.Detached;
            return proj;
        }
    }
}
