using GraphQL.Basic.Models;
using GraphQL.Basic.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Basic.Services.Implementations
{
    public class SubjectService : ISubjectService
    {
        private List<Subject> _subjects = null;

        public SubjectService()
        {
            _subjects = new List<Subject>
            {
                new Subject
                {
                    SubjectID = 1,
                    Name = "Algoritmos e Estrutura de dados",
                    Workload = 60
                },
                new Subject
                {
                    SubjectID = 2,
                    Name = "Desenvolvimento Web",
                    Workload = 40
                }
            };
        }

        public Subject GetSubject(int subjectID)
        {
            return _subjects.Where(s => s.SubjectID == subjectID).FirstOrDefault();
        }

        public List<Subject> GetSubjects()
        {
            return _subjects;
        }

        public Subject Insert(Subject subject)
        {
            _subjects.Add(subject);

            return subject;
        }
    }
}
