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

        public StudentRepository FindByRegistry(Guid studentRegistry)
        {
            Student student = _database.Students
        }
    }
}
