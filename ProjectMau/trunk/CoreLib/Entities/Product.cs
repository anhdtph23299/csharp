using CoreLib.SharedKernel;
using DataTableToOject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class Product 
    {
        [DataNames("Id")]
        public int Id { get; set; }

        [DataNames("ProductName")]
        public string ProductName { get; set; }
        [DataNames("Description")]
        public string Description { get; set; }

        [DataNames("Quantity")]
        public int Quantity { get; set; }

        [DataNames("IdCategory")]
        public int IdCategory { get; set; }

        [DataNames("CategoryName")]
        public string CategoryName { get; set; }
    }
}
