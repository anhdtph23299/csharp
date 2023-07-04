using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces
{
    public interface ICatalogDataProvider
    {
        CResponseMessage Insert(CCatalogs catalogs);
        CResponseMessage Update(CCatalogs catalogs);
        CResponseMessage Delete(int ID);
        CResponseMessage Search(CCatalogs catalogs);
    }
}
