using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProblemDetailFactory.ErrorHandler;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddSingleton<ProblemDetailsFactory, CustomProblemDetailsFactory>();
}
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseExceptionHandler("/error");
app.MapControllers();
app.Run();

