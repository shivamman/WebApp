using ISMTS2WebApp.Data;
using ISMTS2WebApp.Interface;
using ISMTS2WebApp.Models;
using ISMTS2WebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace ISMTS2WebApp.Controllers
{
  public class EmployeeController : Controller
  {
    private readonly IEmployeeService _employeeService;
    private readonly IDepartmentService _departmentService;
    public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
    {
      this._employeeService = employeeService;
      _departmentService = departmentService; 
    }
    public IActionResult Index()
    {
      var list = _employeeService.GetEmployees();
      return View(list);
    }

    public IActionResult Create()
    {
      ViewBag.Departments = _departmentService.GetAllDepartment()
                .Select(i => new SelectListItem
                {
                  Value = i.Id.ToString(),
                  Text = i.Name
                }).ToList();
      //ViewBag.Departments = _departmentService.GetAllDepartment();
      return View();
    }

    [HttpPost]
    public IActionResult Create(Employee employee)
    {
      _employeeService.Create(employee);
      return RedirectToAction("Index");
    }

    public IActionResult Delete(int Id)
    {
      try
      {
        _employeeService.Delete(Id);
        return RedirectToAction("Index");
      }
      catch (System.Exception ex)
      {
        throw new System.Exception(ex.Message);
      }
    }

    public IActionResult Update(int Id)
    {
      ViewBag.Departments = _departmentService.GetAllDepartment()
                .Select(i => new SelectListItem
                {
                  Value = i.Id.ToString(),
                  Text = i.Name
                }).ToList();
      var data = _employeeService.GetById(Id);
      return View(data);
    }

    [HttpPost]
    public IActionResult Update(Employee employee)
    {
      _employeeService.Update(employee);
      return RedirectToAction("Index");
    }
  }
}
