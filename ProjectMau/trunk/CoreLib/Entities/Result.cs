using DataTableToOject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class Result
    {
        [DataNames("Id")]
        public int Id { get; set; }

        [DataNames("ScheduleDate")]
        public DateTime ScheduleDate { get; set; }

        [DataNames("Description")]
        public string Description { get; set; }
    }
}
