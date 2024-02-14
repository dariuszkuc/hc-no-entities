var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddApolloFederation();

var app = builder.Build();
app.MapGraphQL();
app.Run();
