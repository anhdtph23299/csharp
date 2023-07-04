using CoreLib.SharedKernel;
using DataTableToOject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class CCatalogs : CBaseEntity
    {
        [DataNames("ID")]
        public int ID { get; set; }

        [DataNames("CatalogName")]
        public string CatalogName { get; set; }
        [DataNames("Note")]
        public string Note { get; set; }
        [DataNames("DateCreate")]
        public DateTime DateCreate { get; set; }
    }
}
