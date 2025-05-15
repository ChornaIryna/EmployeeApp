using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Web;

public class NameStringAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) => !value.ToString().Contains('@');

}
