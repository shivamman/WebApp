using ISMTS2WebApp.Data;
using ISMTS2WebApp.Interface;
using ISMTS2WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMTS2WebApp.Repository
{
  public class EmployeeService : IEmployeeService
  {
    private readonly AppDbContext _appDbContext;
    public EmployeeService(AppDbContext _appDbContext)
    {
      this._appDbContext = _appDbContext;
    }

    public void Create(Employee employee)
    {
      _appDbContext.Employees.Add(employee);
      _appDbContext.SaveChanges();
    }

    public void Delete(int Id)
    {
      _appDbContext.Employees.Remove(GetById(Id));
      _appDbContext.SaveChanges();
    }

    public Employee GetById(int Id)
    {
      return _appDbContext.Employees.Find(Id);
    }

    public List<Employee> GetEmployees()
    {
      var list = _appDbContext.Employees.Include(x => x.Department).ToList();
      return list;
    }

    public void Update(Employee employee)
    {
      _appDbContext.Employees.Update(employee);
      _appDbContext.SaveChanges();
    }
  }
}
