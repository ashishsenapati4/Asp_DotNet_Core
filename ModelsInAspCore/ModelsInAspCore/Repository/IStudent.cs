using ModelsInAspCore.Models;

namespace ModelsInAspCore.Repository
{
    public interface IStudent
    {
        public List<StudentModel> GetAllStudents();

        public StudentModel GetStudentById(int id);
    }
}
