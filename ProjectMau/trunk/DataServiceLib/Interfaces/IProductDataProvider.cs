using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceLib.Interfaces
{
    public interface IProductDataProvider
    {
        CResponseMessage Insert(Product product);

        CResponseMessage Update(Product product);

        CResponseMessage Delete(int Id);


        CResponseMessage Search(Product product);

        CResponseMessage GetOne(int Id);

        CResponseMessage GetAllCategories();

    }
}
