using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Web.Models;

public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter a Name")]
    [Display(Name = "Name", Prompt = "Employee name")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Enter en Email")]
    [EmailAddress(ErrorMessage = "Enter a valid email")]
    [Display(Name = "Email", Prompt = "Employee email")]
    public string? Email { get; set; }
}
