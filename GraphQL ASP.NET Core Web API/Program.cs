using Microsoft.EntityFrameworkCore;
using GraphQL_ASP.NET_Core_Web_API.DataAccess;
using GraphQL_ASP.NET_Core_Web_API.DataAccess.Repository;
using GraphQL_ASP.NET_Core_Web_API.DataAccess.Interface;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register custom services for the superheroes
builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
builder.Services.AddScoped<ISuperpowerRepository, SuperpowerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();

// Add Application Db Context options
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UsePlayground(new PlaygroundOptions
    {
        QueryPath = "/graphql",
        Path = "/playground"
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
