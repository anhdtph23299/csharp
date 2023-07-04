using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceLib.Interfaces
{
    public interface IResultDataProvider
    {

        CResponseMessage Insert(Result result);
    }
}
