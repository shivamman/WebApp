using ISMTS2WebApp.Models;
using System.Collections.Generic;

namespace ISMTS2WebApp.Interface
{
  public interface IEmployeeService
  {
    List<Employee> GetEmployees();
    void Create(Employee employee);
    void Update(Employee employee);
    void Delete(int Id);
    Employee GetById(int Id);
  }
}
