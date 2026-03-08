using API_Hexagonal_DOTNET.Data.Contexts;
using API_Hexagonal_DOTNET.Entities;
using API_Hexagonal_DOTNET.Interfaces.IRepositories;

namespace API_Hexagonal_DOTNET.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Context _database;
        public StudentRepository()
        {
            
        }

        public Student FindByEmail(string email)
        {
            Student student = _database.Students
                .Select(stdt => stdt)
                .Where(stdt => stdt.Email == email).FirstOrDefault();
            
            return student;
        }
    }
}
