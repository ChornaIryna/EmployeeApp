using EmployeeApp.Web.Models;

namespace EmployeeApp.Web.Services;

public class EmployeeService
{
    List<Employee> employees = [

        new Employee { Id = 1, Name = "John Doe", Email = "joe.doe@test.com" },
        new Employee { Id = 2, Name = "Olena", Email = "olena@test.com" },
        new Employee { Id = 3, Name = "Sarbast", Email = "sarbast@test.com" },
        new Employee { Id = 4, Name = "Iryna", Email = "iryna@test.com" }
    ];

    public void AddEmployee(Employee employee)
    {
        employee.Id = employees.Count > 0 ? employees.Max(e => e.Id) + 1 : 1;
        employees.Add(employee);
    }

    public Employee[] GetAll() => employees.OrderBy(e => e.Name).ToArray();

    public Employee GetById(int id) => employees.Single(e => e.Id == id);
}
