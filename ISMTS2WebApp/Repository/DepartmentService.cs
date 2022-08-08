using ISMTS2WebApp.Data;
using ISMTS2WebApp.Interface;
using ISMTS2WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMTS2WebApp.Repository
{
  public class DepartmentService : IDepartmentService
  {
    private readonly AppDbContext _appDbContext;
    public DepartmentService(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
    }

    public void CreateDepartment(Department department)
    {
      _appDbContext.Departments.Add(department);
      _appDbContext.SaveChanges();
    }

    public List<Department> GetAllDepartment()
    {
      return _appDbContext.Departments.ToList();
    }

    public Department GetById(int id)
    {
      return _appDbContext.Departments.Find(id);
    }

    public void Update(Department employee)
    {
      _appDbContext.Departments.Update(employee);
      _appDbContext.SaveChanges();
    }
  }
}
