using ModelsInAspCore.Models;

namespace ModelsInAspCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> GetAllStudents()
        {
            return StudentData();
        }

        public StudentModel GetStudentById(int id)
        {
            return StudentData().Where(x => x.StudentId == id).FirstOrDefault();
        }

        private List<StudentModel> StudentData()
        {
            return new List<StudentModel>
            {
                new StudentModel {StudentId = 899, StudentName = "Ashish", StudentEmail = "ashish@gmail.com", StudentPhone = 73882882},
                new StudentModel {StudentId = 874, StudentName = "Amita", StudentEmail = "amita@gmail.com", StudentPhone = 56256277},
                new StudentModel {StudentId = 425, StudentName = "Pooja", StudentEmail = "pooja@gmail.com", StudentPhone = 02882992},
                new StudentModel {StudentId = 788, StudentName = "Subha", StudentEmail = "subha@gmail.com", StudentPhone = 73882882},
                new StudentModel {StudentId = 526, StudentName = "tara", StudentEmail = "tara@gmail.com", StudentPhone = 56256277},
                new StudentModel {StudentId = 988, StudentName = "Anu", StudentEmail = "anu@gmail.com", StudentPhone = 02882992},

            };
        }
       
    }
}
    
