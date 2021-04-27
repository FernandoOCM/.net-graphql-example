using GraphQL.Basic.Server;
using GraphQL.Basic.Services.Implementations;
using GraphQL.Basic.Services.Interfaces;
using GraphQL.Basic.Types;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQL.Basic
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInMemorySubscriptions();

            services.AddSingleton<IStudentService, StudentService>();
            services.AddSingleton<ISubjectService, SubjectService>();

            services.AddScoped<Mutation>();
            services.AddScoped<Query>();
            services.AddScoped<Subscription>();

            services
                .AddGraphQLServer()
                .AddQueryType<QueryType>()
                .AddMutationType<Mutation>()
                .AddSubscriptionType<Subscription>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions
                {
                    QueryPath = "/graphql",
                    Path = "/playground"
                });
            }

            app
                .UseWebSockets()
                .UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapGraphQL();
                });
        }
    }
}
