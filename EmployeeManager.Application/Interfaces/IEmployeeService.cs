using EmployeeManager.Application.ViewModels.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeVm>> GetAllEmployees();
        Task AddNewEmployee(EmployeeVm newEmployee);
    }
}
