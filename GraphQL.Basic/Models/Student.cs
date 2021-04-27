using System.Collections.Generic;

namespace GraphQL.Basic.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
