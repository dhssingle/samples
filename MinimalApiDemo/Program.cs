using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IFooService, FooService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = builder.Environment.ApplicationName,
        Version = "v1"
    });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{builder.Environment.ApplicationName} v1"));
}
app.MapGet("/", () => Results.Redirect("/swagger/index.html"));

app.MapGet("hello", () => "Hello Minimal APIs");

app.MapGet("header", ([FromHeader(Name = "Content-Type")] string contentType) => contentType);

app.MapGet("hello/{id}", (int id) => id);

app.MapPost("person", ([FromBody] Person person) => person);

app.MapGet("person/{id:guid}", (Guid id) => new Person(id, "三", "张", 100, "male"));

app.MapPut("person/{id:guid}", (Guid id) => Results.NoContent());

app.MapDelete("person/{id}", (Guid id) => Results.NoContent());

app.MapGet("/foo", (IFooService service) => service.Get());

app.Run("http://localhost:8081");

record Person(Guid Id, string FirstName, string LastName, int Age, string Gender);
