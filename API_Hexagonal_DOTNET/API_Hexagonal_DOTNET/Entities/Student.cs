namespace API_Hexagonal_DOTNET.Entities
{
    public class Student
    {
        public Guid Registry { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public int CPF { get; set; }
        public string Email {  get; set; }

        public Student()
        {
            this.Registry = Guid.NewGuid();
        }
    }
}
