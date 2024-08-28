using IGI.Icegate_Integration.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200", "https://my-angular-project-eight.vercel.app/")
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials();
    });
});
builder.Services.AddDbContext<IGIdbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("IceGateIntegration")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("MyPolicy");

app.MapControllers();

app.Run();
