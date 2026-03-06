using API_Hexagonal_DOTNET.DTOs;
using API_Hexagonal_DOTNET.Entities;

namespace API_Hexagonal_DOTNET.Interfaces.IServices
{
    public interface IStudentService
    {
        public Student GetStudentData(Guid registry);
        public List<Student> GetAllStudents();
        public void Register(StudentDTO studentDTO);
    }
}
