using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISMTS2WebApp.Models
{
  public class Department
  {
    public int Id { get; set; }

    [Required]
    [DisplayName("Department Name")]
    public string Name { get; set; }
  }
}
