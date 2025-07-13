using Microsoft.AspNetCore.Mvc;

namespace Lab2App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = new[] {
                new { Id = 1, Name = "Alice", Department = "HR" },
                new { Id = 2, Name = "Bob", Department = "Finance" }
            };
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] object employee)
        {
            return Ok(new { Message = "Employee added successfully", Employee = employee });
        }
    }
}
