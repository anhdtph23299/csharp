using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Interfaces
{
    /// <summary>
    /// 2018-12-23 11:03:49 ngocta2
    /// xu ly exception, thuongla ghi log
    /// </summary>
    public interface IErrorHandler
    {
        void WriteToFile(Exception ex);
    }
}
