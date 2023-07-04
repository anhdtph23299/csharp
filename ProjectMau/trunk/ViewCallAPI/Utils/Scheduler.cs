using System.Timers;
using TrainningDotNetCore;
using Timer = System.Timers.Timer;

namespace ViewCallAPI.Utils
{
    public class Scheduler
    {
        public async void SaveResult()
        {
            DateTime dateNow = DateTime.Now;

            DateTime dateNeedSave = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day,11,30,0);

            TimeSpan timeSpan = dateNow-dateNeedSave;

             if(timeSpan < TimeSpan.Zero) { 
                dateNeedSave = dateNeedSave.AddDays(1);
                timeSpan = dateNeedSave - dateNow;
                }
            Timer timer = new Timer(timeSpan.TotalMilliseconds);
            timer.Elapsed += (sender, e) =>
            {
                // Thực thi phương thức vào 5 giờ chiều
                //YourMethodToExecute();
                // Đặt thời gian chạy cho ngày tiếp theo
                timer.Interval = TimeSpan.FromDays(1).TotalMilliseconds;
            };
            timer.Start();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

    }
}
