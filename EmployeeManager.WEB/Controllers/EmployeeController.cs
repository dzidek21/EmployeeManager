using EmployeeManager.Application.Interfaces;
using EmployeeManager.Application.ViewModels.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManager.WEB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeSrevice;
        private readonly IProjectService _projectSrevice;
        public EmployeeController(IEmployeeService employeeSrevice, IProjectService projectSrevice)
        {
            _employeeSrevice = employeeSrevice;
            _projectSrevice = projectSrevice;
        }

        // GET: EmployeeController
        public async Task <ActionResult> Index()
        {
            var employees = await _employeeSrevice.GetAllEmployees();
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            // ReSharper disable once Mvc.ViewNotResolved
            return View();
        }

        // GET: EmployeeController/Create
        public async Task <ActionResult> Create()
        {
            var projects =await _projectSrevice.GetAllProjects();
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
                await _employeeSrevice.AddNewEmployee(newEmployeeVm);
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
