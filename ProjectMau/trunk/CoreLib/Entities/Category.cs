using CoreLib.SharedKernel;
using DataTableToOject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class Category 
    {
        [DataNames("Id")]
        public int Id { get; set; }

        [DataNames("CategoryName")]
        public string CategoryName { get; set; }

    }
}
