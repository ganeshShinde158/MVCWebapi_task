using Microsoft.EntityFrameworkCore;
using MVCWebapi_task.Models;
using MVCWebapi_task.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SenwellDbsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));


});
builder.Services.AddTransient<IUserServices, UserServices>();
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
