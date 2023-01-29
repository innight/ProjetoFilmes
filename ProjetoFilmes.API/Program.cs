using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.API.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjetoFilmesAPIContext") ?? throw new InvalidOperationException("Connection string 'ProjetoFilmesAPIContext' not found.")));

// Add services to the container.

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

app.UseCors(options =>
{
    //Vou abrir completamente esta app web api para todos os pedidos de todos os outros projetos:
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
}
);

app.UseAuthorization();

app.MapControllers();

app.Run();
