using GraphQL.Basic.Models;
using GraphQL.Basic.Services.Interfaces;
using System.Collections.Generic;

namespace GraphQL.Basic.Services.Implementations
{
    public class StudentService : IStudentService
    {
        ISubjectService _subjectService = null;

        public StudentService(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public Student GetStudent(int ID)
        {
            return new Student()
            {
                StudentID = ID,
                Name = $"student {ID}",
                Subjects = _subjectService.GetSubjects()
            };
        }

        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            for (int i = 1; i <= 2; i++)
            {
                students.Add(new Student()
                {
                    StudentID = i,
                    Name = $"student {i}",
                    Subjects = _subjectService.GetSubjects()
                });
            }

            return students;
        }
    }
}
