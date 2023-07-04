using CoreLib.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class CNews : CBaseEntity
    {        
        public int ID { get; set; }
        public string NewName { get; set; }
        public int CatalogID { get; set; }
        public string ImageSource { get; set; }
        public string Summary { get; set; }
        public string Note { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
