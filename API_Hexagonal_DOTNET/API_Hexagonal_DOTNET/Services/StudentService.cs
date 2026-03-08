using API_Hexagonal_DOTNET.DTOs;
using API_Hexagonal_DOTNET.Entities;
using API_Hexagonal_DOTNET.Interfaces.IRepositories;
using API_Hexagonal_DOTNET.Interfaces.IServices;

namespace API_Hexagonal_DOTNET.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetStudentData(Guid registry)
        {
            //código
        }

        public List<Student> GetAllStudents()
        {
            //código
        }

        public void Register(StudentDTO studentDTO)
        {
            try
            {
                if(studentDTO.FirstName == null || studentDTO.LastName == null)
                {
                    throw new Exception("Nome completo deve ser informado nos campos respectivos!");
                }
                if(studentDTO.FirstName.Length>50 || studentDTO.LastName.Length>50)
                {
                    throw new Exception("Nome excede limite de caracteres!");
                }
                if(!studentDTO.Email.EndsWith("@faculdade.edu"))
                {
                    throw new Exception("E-mail inválido!");
                }

                Student savedStudent = _studentRepository.FindByEmail(studentDTO.Email);

                if(savedStudent != null)
                {
                    throw new Exception("E-mail já cadastrado!");
                }

                Student newStudent = new Student();
                newStudent.FirstName = studentDTO.FirstName;
                newStudent.LastName = studentDTO.LastName;
                newStudent.Email = studentDTO.Email;
                newStudent.CPF = studentDTO.CPF;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
