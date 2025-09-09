var builder = WebApplication.CreateBuilder(args);

// Add CORS so React frontend can fetch
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000") // React dev server
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add services to support controllers
builder.Services.AddControllers();

// Optional: Add OpenAPI/Swagger for testing in browser
builder.Services.AddOpenApi();

var app = builder.Build();

// Enable CORS
app.UseCors();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Map all controller routes
app.MapControllers();

app.Run();
