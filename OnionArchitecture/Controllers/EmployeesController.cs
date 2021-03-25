using Domainlayer.Models;
using Microsoft.AspNetCore.Mvc;
using Servicelayer.Services;


namespace OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var result = _employeeService.GetEmployees();
            if (result is not null)
            {
                return Ok(result);
            }
            return NoContent();
        }

      
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var result = _employeeService.GetEmployee(id);
            if (result is null)
            {
                return NotFound("Employee Not Found");
            }
            return Ok(result);
        }
   
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            _employeeService.CreateEmployee(employee);
            return CreatedAtAction(nameof(GetEmployee),new { id= employee.Id },employee);
        }

        
        [HttpPut(nameof(UpdateEmployee))]
        public IActionResult UpdateEmployee( [FromBody] Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeService.DeleteEmployee(id);
            return Ok();
        }
    }
}
