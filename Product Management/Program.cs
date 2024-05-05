using Microsoft.OpenApi.Models;
using Product.Management.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Logging.ClearProviders();
builder.Services.AddSingleton(builder.Configuration);
builder.Services.AddDependencyInjectionSetup(builder.Configuration);
builder.Services.AddDataBaseSetup(builder.Configuration);
builder.Services.AddAutoMapperSetup();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Financial Product Management", Version = "v1" });
});

//SerilogConfig.AddSerilogApi(builder.Configuration);
//builder.WebHost.UseSerilog();

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
