using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.OpenApi.Models;
using Lab3App.Filters; // Namespace where your CustomAuthFilter and CustomExceptionFilter are
using Lab3App.Models;  // Namespace where your Employee model is (adjust if different)

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Swagger Demo",
        Version = "v1",
        Description = "Simple demo API for Swagger integration",
        Contact = new OpenApiContact
        {
            Name = "John Doe",
            Url = new Uri("https://example.com"),
            Email = "john@example.com"
        }
    });
});

// Register custom filters
builder.Services.AddScoped<CustomAuthFilter>();
builder.Services.AddScoped<CustomExceptionFilter>();

var app = builder.Build();

// Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

// HTTPS redirection and authorization
app.UseHttpsRedirection();
app.UseAuthorization();

// Apply global exception filter
app.Use(async (context, next) =>
{
    var exceptionFilter = context.RequestServices.GetRequiredService<CustomExceptionFilter>();

    try
    {
        await next();
    }
    catch (Exception ex)
    {
        var actionContext = new ActionContext
        {
            HttpContext = context
        };

        var exceptionContext = new ExceptionContext(actionContext, new List<IFilterMetadata>())
        {
            Exception = ex
        };

        exceptionFilter.OnException(exceptionContext);
    }
});


app.MapControllers();

app.Run();
