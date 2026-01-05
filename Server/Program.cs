using Server.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<ITimestampService, TimestampService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

var timestampService = app.Services.GetRequiredService<ITimestampService>();

app.UseHttpsRedirection();

app.MapGet("/timestamp", timestampService.GetTimestamp).WithName("GetTimestamp");

app.Run();