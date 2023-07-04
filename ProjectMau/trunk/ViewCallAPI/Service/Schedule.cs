using CoreLib.Entities;
using DataServiceLib.Interfaces;
using Quartz;
using System.Text;
using System.Text.Json;

namespace ViewCallAPI.Service
{
    public class Schedule : IJob
    {
        IResultDataProvider _resultDataProvider;
        public Schedule(IResultDataProvider resultDataProvider)
        {
            _resultDataProvider = resultDataProvider;
        }

        public Task Execute(IJobExecutionContext context)
        {
            Result result = new Result();
            result.ScheduleDate = DateTime.Now;
            result.Description = "Test time";
            _resultDataProvider.Insert(result);

            return Task.CompletedTask;
        }



    }
}
