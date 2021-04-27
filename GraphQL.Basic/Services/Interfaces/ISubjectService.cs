using GraphQL.Basic.Models;
using System.Collections.Generic;

namespace GraphQL.Basic.Services.Interfaces
{
    public interface ISubjectService
    {
        List<Subject> GetSubjects();
        Subject GetSubject(int subjectID);
        Subject Insert(Subject subject);
    }
}
