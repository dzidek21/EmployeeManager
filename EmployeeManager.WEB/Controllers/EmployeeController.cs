using EmployeeManager.Application.Interfaces;
using EmployeeManager.Application.ViewModels.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManager.WEB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IProjectService _projectService;
        private readonly IProjectHistoryService _projectHistoryService;


        public EmployeeController(IEmployeeService employeeService, IProjectService projectService, IProjectHistoryService projectHistoryService)
        {
            _employeeService = employeeService;
            _projectService = projectService;
            _projectHistoryService = projectHistoryService;
        }

        // GET: EmployeeController
        public async Task <ActionResult> Index()
        {
            var employees = await _employeeService.GetAllEmployees();
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public async Task< ActionResult> Details(int id)
        {
            var projectHistroy = await _projectHistoryService.GetAllProjectsForEmployee(id);
            var employee = await _employeeService.GetEmployeeById(id);
            employee.ProjectsHistory = projectHistroy;
            return View(employee);
        }

        // GET: EmployeeController/Create
        public async Task <ActionResult> Create()
        {
            var projects =await _projectService.GetAllProjects();
            ViewBag.Projects = new SelectList(projects, "Id","ProjectName");
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< ActionResult> Create(EmployeeVm newEmployeeVm)
        {
            try
            {
                await _employeeService.AddNewEmployee(newEmployeeVm);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
