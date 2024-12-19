var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sql")
                 .WithLifetime(ContainerLifetime.Persistent)
                 .AddDatabase("portfolioDb");

builder.AddProject<Projects.AspirePortfolioApp_Api>("api")
    .WithReference(sqlServer);
builder.Build().Run();
