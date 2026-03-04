using API_Hexagonal_DOTNET.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Hexagonal_DOTNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            //codigo
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
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
