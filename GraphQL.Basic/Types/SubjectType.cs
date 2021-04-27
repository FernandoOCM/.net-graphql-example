using GraphQL.Basic.Models;
using HotChocolate.Types;

namespace GraphQL.Basic.Types
{
    public class SubjectType : ObjectType<Subject>
    {
        protected override void Configure(IObjectTypeDescriptor<Subject> descriptor)
        {
            //Descreve os atributos com o FluentAPI
            descriptor
                .Description("The subjects that a student can study");

            descriptor
                .Field(s => s.SubjectID)
                .Type<IntType>()
                .Description("The Id of a subject");

            descriptor
                .Field(s => s.Name)
                .Type<StringType>()
                .Description("The name of a subject ");

            descriptor
                .Field(s => s.Workload)
                .Type<IntType>()
                .Description("The workload of a subject");
        }
    }
}
