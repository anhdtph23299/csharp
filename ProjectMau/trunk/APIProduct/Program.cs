using CommonLib.Implementations;
using CommonLib.Interfaces;
using DataServiceLib.Implementations;
using DataServiceLib.Interfaces;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc;
using TrainningDotNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
services.AddLocalization(options => options.ResourcesPath = "Resources");
services.AddMvc()
   .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
   .AddDataAnnotationsLocalization(options => options.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(SharedResource)))
   .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

var myAllowSpecificOrigins = "_MyAllowSpecificOrigins";

services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
    policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
var myAllowPjSpecificOrigins = "_MyAllowSpecificOrigins";

services.AddCors(options =>
{
    options.AddPolicy(name: myAllowPjSpecificOrigins,
    policy =>
    {
        policy.WithOrigins("https://localhost:44361")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
var configuration = builder.Configuration;
services.AddSingleton<IConfiguration>(configuration);

var serilogProvider = new CSerilog(configuration, null);
services.AddSingleton<ISerilogProvider>(serilogProvider);

services.AddScoped<IProductDataProvider, CProductDataProvider>();
services.AddScoped<IDanhMucDataProvider, CDanhMucDataProvider>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


 //Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseSwagger();
 app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(myAllowSpecificOrigins);

app.UseCors(myAllowPjSpecificOrigins);
app.Run();
