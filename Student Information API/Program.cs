using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Student_Information_API.Models;
using Student_Information_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<StudentDBsettings>(
builder.Configuration.GetSection(nameof(StudentDBsettings)));

builder.Services.AddSingleton<IStudentDBsettings>(sp =>
sp.GetRequiredService<IOptions<StudentDBsettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("StudentDBSettings:ConnectionString")));
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
