using webAPI.Data;
using webAPI.Services.MusicServices;

var builder = WebApplication.CreateBuilder(args);
Context.serverName = ""; //Server name
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMusicSerivice, MusicService>(); //Burada hangi interface hangi service için kullanýlacak bilgisi veriliyor.
//Yani hangi class hangi interface i implement edecek onun bilgisi veriliyor.

builder.Services.AddDbContext<Context>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
