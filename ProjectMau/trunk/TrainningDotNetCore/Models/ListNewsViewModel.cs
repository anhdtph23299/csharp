using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainningDotNetCore.Models
{
    public class ListNewsViewModel
    {
        public List<CNews> ListNews { get; set; }

        public CNews cNews { get; set; }

        public CResponseMessage ReturnMess { get; set; }

        public List<CCatalogs> ListDanhMuc { get; set; }
    }
}
