using GraphQL.Basic.Models;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQL.Basic.Server
{
    public class Subscription
    {
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<Subject>> OnSubjectCreate([Service] ITopicEventReceiver eventReceiver,
          CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<string, Subject>("SubjectCreated", cancellationToken);
        }
    }
}