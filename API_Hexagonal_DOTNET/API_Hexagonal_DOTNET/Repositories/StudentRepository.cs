using API_Hexagonal_DOTNET.Data.Contexts;
using API_Hexagonal_DOTNET.Entities;
using API_Hexagonal_DOTNET.Interfaces.IRepositories;

namespace API_Hexagonal_DOTNET.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Context _database;
        public StudentRepository(Context database)
        {
            _database = database;
        }

        public Student FindByEmail(string email)
        {
            Student student = _database.Students
                .Select(stdt => stdt)
                .Where(stdt => stdt.Email == email).FirstOrDefault();

            return student;
        }

        public Student FindByRegistry(Guid registry)
        {
            Student student = _database.Students
                .Select(stdt => stdt)
                .Where(stdt => stdt.Registry == registry).FirstOrDefault();

            return student;
        }

        public List<Student> SelectAll()
        {
            return _database.Students.ToList();
        }

        public void Save(Student newStudent)
        {
            _database.Students.Add(newStudent);
            _database.SaveChanges();
        }
    }
}
