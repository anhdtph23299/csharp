using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainningDotNetCore.Models
{
    public class ListProductViewModel
    {
        public List<Product> ListProduct { get; set; }

        public Product product { get; set; }

        public CResponseMessage ReturnMess { get; set; }

    }
}
