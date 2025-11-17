namespace DependencyInjectionExp.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int id);

        List<Student> GetAllStudent();
    }
}
