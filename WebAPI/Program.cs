using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Map;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//  Dependency Injection
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MapperProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<MyDatabase>(options => 
{
	options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
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
