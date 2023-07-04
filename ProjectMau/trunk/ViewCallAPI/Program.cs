using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc;
using CommonLib.Implementations;
using CommonLib.Interfaces;
using DataServiceLib.Interfaces;
using DataServiceLib.Implementations;
using TrainningDotNetCore;
using ViewCallAPI.Service;
using System.Threading;
using Quartz.Impl;
using Quartz;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;

services.AddControllersWithViews();

services.AddLocalization(options => options.ResourcesPath = "Resources");

services.AddMvc()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization(options => options.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(SharedResource)))
    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0); // Thay thế version phù hợp với phiên bản .NET Core 6.0

var configuration = builder.Configuration;
services.AddSingleton<IConfiguration>(configuration);

var serilogProvider = new CSerilog(configuration, null);
services.AddSingleton<ISerilogProvider>(serilogProvider);

services.AddScoped<Schedule>();

services.AddScoped<IProductDataProvider, CProductDataProvider>();

services.AddScoped<IResultDataProvider, CResultDataProvider>();

services.AddHttpClient();
services.AddQuartz(q =>
{
    var currentTime = DateTimeOffset.Now;
    var scheduledTime = new DateTimeOffset(currentTime.Year, currentTime.Month, currentTime.Day, 17, 52, 00, currentTime.Offset);

    if (scheduledTime <= currentTime)
        scheduledTime = scheduledTime.AddDays(1);

    q.UseMicrosoftDependencyInjectionScopedJobFactory();
    var jobKey = new JobKey("Schedule");
    q.AddJob<Schedule>(opts => opts.WithIdentity(jobKey));

    q.AddTrigger(opts => opts
        .ForJob(jobKey)
        .WithIdentity("DemoJob-trigger")
        .StartAt(scheduledTime) 
        .WithSimpleSchedule(x => x
            .WithIntervalInSeconds(10)));// Công việc được lập lịch chạy sau mỗi 30 giây
           // .RepeatForever())); // Lặp lại vô hạn
});

services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ProductView}/{action=Index}/{id?}");

//using (var scope = app.Services.CreateScope())
//{
//    var services1 = scope.ServiceProvider;
//    var schedule = services1.GetRequiredService<Schedule>();

//    var currentTime = DateTime.Now;

//    var scheduledTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 17, 28, 40);

//    if (currentTime > scheduledTime)
//    {
//        scheduledTime = scheduledTime.AddDays(1);
//    }

//    var dueTime = scheduledTime - currentTime;

//    var timer = new Timer(state =>
//    {
//        schedule.ScheduleDaily();
//    }, null, dueTime, TimeSpan.FromMinutes(1));
//}
//using (var scope = app.Services.CreateScope())
//{
//    IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().;
//    scheduler.Start();

//    IJobDetail job = JobBuilder.Create<Schedule>().Build();

//    ITrigger trigger = TriggerBuilder.Create().StartNow()
//        .WithDailyTimeIntervalSchedule
//          (s =>
//             s.WithIntervalInHours(24)
//            .OnEveryDay()
//            .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
//          )
//        .Build();

//    scheduler.ScheduleJob(job, trigger);
//}




app.Run();


