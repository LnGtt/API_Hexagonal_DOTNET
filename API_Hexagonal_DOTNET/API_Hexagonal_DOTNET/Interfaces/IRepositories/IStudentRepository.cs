using API_Hexagonal_DOTNET.Entities;

namespace API_Hexagonal_DOTNET.Interfaces.IRepositories
{
    public interface IStudentRepository
    {
        public Student FindByEmail(string email);
    }
}
