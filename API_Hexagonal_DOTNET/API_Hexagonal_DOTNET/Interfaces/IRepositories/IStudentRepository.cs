using API_Hexagonal_DOTNET.Entities;

namespace API_Hexagonal_DOTNET.Interfaces.IRepositories
{
    public interface IStudentRepository
    {
        public Student FindByEmail(string email);
        public Student FindByRegistry(Guid registry);
        public List<Student> SelectAll();
        public void Save(Student newStudent);
    }
}
