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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ContextDb _context;

        public EmployeeRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task AddNewEmployee(Employee newEmployee)
        {
            var newEmp = new Employee()
            {
                FirstName =newEmployee.FirstName,
                LastName=newEmployee.LastName,
                CurrentProjectId=newEmployee.CurrentProjectId,
                CurrentProject=newEmployee.CurrentProject,
            };
            await _context.Employees.AddAsync(newEmp);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var emp = await _context.Employees.Include(x => x.CurrentProject).ToListAsync();
            return emp;
        }
    }
}
