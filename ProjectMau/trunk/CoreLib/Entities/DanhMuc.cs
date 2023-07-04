using DataTableToOject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class DanhMuc
    {
        [DataNames("Id")]
        public int Id { get; set; }

        [DataNames("TenDanhMuc")]
        public string TenDanhMuc { get; set; }

    }
}
