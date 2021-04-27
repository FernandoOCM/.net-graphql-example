using GraphQL.Basic.Models;
using GraphQL.Basic.Services.Interfaces;
using HotChocolate;
using HotChocolate.Subscriptions;
using System.Threading.Tasks;

namespace GraphQL.Basic.Server
{
    public class Mutation
    {
        ISubjectService _subjectService = null;

        public Mutation(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public async Task<Subject> CreateSubject(Subject subject, [Service] ITopicEventSender eventSender)
        {
            _subjectService.Insert(subject);

            await eventSender.SendAsync("SubjectCreated", subject);

            return subject;
        }
    }
}
