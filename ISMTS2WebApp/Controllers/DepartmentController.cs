using ISMTS2WebApp.Interface;
using ISMTS2WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISMTS2WebApp.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            this._departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var data = _departmentService.GetAllDepartment();
            return View(data);
        }
        public IActionResult Create()
        {
            //ViewBag.Departments = _departmentService.GetAllDepartment();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentService.CreateDepartment(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }
        public IActionResult Edit(int Id)
        {
            var data = _departmentService.GetById(Id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            _departmentService.Update(department);
            return RedirectToAction("Index");
        }

    }
}
