using GraphQL.Basic.Models;
using System.Collections.Generic;

namespace GraphQL.Basic.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudent(int ID);
    }
}
