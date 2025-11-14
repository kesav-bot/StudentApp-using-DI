using System.Collections.Generic;
using System.Linq;
using StudentApp.Models;

namespace StudentApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students;

        // Constructor initializes sample data
        public StudentService()
        {
            _students = new List<Student>
            {
                new Student { Id = 1, Name = "Kesavan", Course = "C#" },
                new Student { Id = 2, Name = "Rahul", Course = "ASP.NET Core" },
                new Student { Id = 3, Name = "Sai", Course = "SQL Server" }
            };
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetStudentById(int i)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }
    }
}
