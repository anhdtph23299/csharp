﻿using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceLib.Interfaces
{
    public interface INewDataProvider
    {
        CResponseMessage Insert(CNews news);
    }
}
