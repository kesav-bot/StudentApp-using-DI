using StudentApp.Models;

namespace StudentApp.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
    }
}
