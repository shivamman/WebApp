using ISMTS2WebApp.Models;
using System.Collections.Generic;

namespace ISMTS2WebApp.Interface
{
  public interface IDepartmentService
  {
    List<Department> GetAllDepartment();
    void CreateDepartment(Department department);
    Department GetById(int id);
    void Update(Department employee);
  }
}
