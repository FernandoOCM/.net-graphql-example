using GraphQL.Basic.Server;
using HotChocolate.Types;

namespace GraphQL.Basic.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Description("Querys to fetch data from the application.");

            descriptor
                .Field(q => q.Subject(default))
                .Type<SubjectType>()
                .Description("Search for subject by ID")
                .Argument(
                    "subjectID",
                    argDescriptor => argDescriptor
                        .Type<IntType>()
                        .Description("The subjectId to seach on")
                );
        }
    }
}
