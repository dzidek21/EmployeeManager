using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManager.Application.ViewModels.Employee;
using EmployeeManager.Application.ViewModels.Project;
using EmployeeManager.Application.ViewModels.ProjectHistory;
using EmployeeManager.Domain.Models;

namespace EmployeeManager.Application.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeVm>().
                ForMember(x => x.CurrentProject, opt => opt.MapFrom(x => x.CurrentProject)).
                ReverseMap();
            CreateMap<Project, ProjectVm>().
                ForMember(x=>x.Employees,opt=>opt.MapFrom(x=>x.Employees)).
                ReverseMap();
            CreateMap<EmployeeProjectHistory, ProjectHistoryVm>().ReverseMap();
        }
    }
}
