using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISMTS2WebApp.Models
{
  public class Employee
  {
    public int Id { get; set; }

    [DisplayName("First Name")]
    [Required]
    public string FirstName { get; set; }

    [DisplayName("Last Name")]
    [Required]
    public string LastName { get; set; }

    [DisplayName("Select a Department")]
    public int DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    public Department Department { get; set; }
  }
}
