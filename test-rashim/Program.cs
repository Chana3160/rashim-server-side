 global using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
 using test_rashim.Models;
using test_rashim.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAuthor, AuthorService>();
builder.Services.AddScoped<ITitle, TiteService>();
builder.Services.AddScoped<IOrder, OrderService>();
builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddDbContext<PubsContext>(optionsBuilder => optionsBuilder.UseSqlServer("Server=DESKTOP-8MOD252;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true;"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corspolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
