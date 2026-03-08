using API_Hexagonal_DOTNET.DTOs;
using API_Hexagonal_DOTNET.Entities;
using API_Hexagonal_DOTNET.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace API_Hexagonal_DOTNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                var students = _service.GetAllStudents();

                if (students == null || !students.Any())
                {
                    return NoContent();
                }

                return Ok(students); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }

        [HttpGet("GetStudentData")]
        public IActionResult GetStudentData([FromQuery] Guid id)
        {
            Student studentResponse = _service.GetStudentData(id);
            return Ok(studentResponse);
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] StudentDTO register)
        {
            try
            {
                _service.Register(register);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
