using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lab5App.Models;

namespace Lab5App.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize(Roles = "Admin")] // Access only if role is Admin
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployee()
    {
        var emp = new Employee
        {
            Id = 1,
            Name = "John Doe",
            Salary = 50000,
            Permanent = true,
            Department = new Department { Id = 101, Name = "IT" },
            Skills = new List<Skill> { new Skill { Id = 1, Name = "C#" } },
            DateOfBirth = new DateTime(1990, 1, 1)
        };
        return Ok(emp);
    }
}
