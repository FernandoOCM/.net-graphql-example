using GraphQL.Basic.Models;
using GraphQL.Basic.Services.Interfaces;
using System.Collections.Generic;

namespace GraphQL.Basic.Server
{
    public class Query
    {
        IStudentService _studentService = null;
        ISubjectService _subjectService = null;

        public Query(IStudentService studentService,
            ISubjectService subjectService
        )
        {
            _studentService = studentService;
            _subjectService = subjectService;
        }

        #region Student
        public List<Student> Students => _studentService.GetStudents();
        public Student Student(int studentID) => _studentService.GetStudent(studentID);
        #endregion

        #region Subject
        public List<Subject> Subjects => _subjectService.GetSubjects();
        public Subject Subject(int subjectID) => _subjectService.GetSubject(subjectID);
        #endregion
    }
}
