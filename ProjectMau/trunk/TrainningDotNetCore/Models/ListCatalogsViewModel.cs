using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainningDotNetCore.Models
{
    public class ListCatalogsViewModel
    {
        public List<CCatalogs> ListCatalog { get; set; }

        public CCatalogs cCatalog { get; set; }

        public CResponseMessage ReturnMess { get; set; }

    }
}
