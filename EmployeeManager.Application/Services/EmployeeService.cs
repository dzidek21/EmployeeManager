using EmployeeManager.Application.Interfaces;
using EmployeeManager.Application.ViewModels.Employee;
using EmployeeManager.Infrastructure.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.Domain.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using EmployeeManager.Domain.Models;

namespace EmployeeManager.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepo, IMapper mapper)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }

        public async Task AddNewEmployee(EmployeeVm newEmployee)
        {
            EmployeeVm employeeVm = new EmployeeVm();
            employeeVm = newEmployee;
            
            var emp = _mapper.Map<EmployeeVm, Employee>(newEmployee);
            await _employeeRepo.AddNewEmployee(emp);
            
        }

        public async Task<EmployeeVm> GetEmployeeById(int id)
        {
            var employee =await _employeeRepo.GetEmployeeById(id);
            return _mapper.Map<Employee, EmployeeVm>(employee);
        }

        public async Task <List<EmployeeVm>> GetAllEmployees()
        {
            var employees = await _employeeRepo.GetAllEmployees();
            
            var emp = _mapper.Map<List<Employee>, List<EmployeeVm>>(employees);
            return emp;
        }
    }
}
