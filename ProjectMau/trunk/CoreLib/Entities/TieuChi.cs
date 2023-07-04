using DataTableToOject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class TieuChi
    {
        [DataNames("Id")]
        public int Id { get; set; }

        [DataNames("TenTieuChi")]
        public string TenTieuChi { get; set; }

    }
}
