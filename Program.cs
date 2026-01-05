var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/timestamp", () =>
{
    return new Timestamp(DateTime.UtcNow);
})
.WithName("GetTimestamp");

app.Run();

record Timestamp(DateTime Date)
{
}
