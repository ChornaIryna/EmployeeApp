using EmployeeApp.Web.Models;
using EmployeeApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Web.Controllers;

public class EmployeesController : Controller
{
    private static EmployeeService employeeService = new EmployeeService();

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = employeeService.GetAll();
        return View(model);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Employee employee)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        employeeService.AddEmployee(employee);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        var employee = employeeService.GetById(id);
        if (employee == null)
        {
            return NotFound();
        }
        return View(employee);
    }

}
