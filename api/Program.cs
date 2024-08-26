//control things, like dependecies, provide services
using api.Data;
using api.Interfaces;
using api.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddNewtonsoftJson(options => {
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
}); // Configures JSON serialization to ignore reference loops, preventing errors during object serialization

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
    
    options.UseMySql(connectionString, serverVersion);
});

builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();

var app = builder.Build(); 

//configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

