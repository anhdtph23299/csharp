using BaseDataLib.Implementations;
using CommonLib.Implementations;
using CommonLib.Interfaces;
using CoreLib.Entities;
using CoreLib.Interfaces;
using Dapper;
using DataServiceLib.Interfaces;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataServiceLib.Implementations
{
    /// <summary>
    /// 2018-12-22 21:17:02 ngocta2
    /// class xu ly data user
    /// </summary>
    public class CNewDataProvider : CBaseDataProvider, INewDataProvider
    {
        // const
      

        // vars
        private readonly IConfiguration _configuration;


        /// <summary>
        /// 2018-12-22 21:13:58 ngocta2
        /// contructor, lay conn string, logger instance
        /// </summary>
        /// <param name="strConnectionString"></param>
        public CNewDataProvider(IConfiguration configuration, ISerilogProvider serilogProvider)
            : base(serilogProvider)
        {
            // conn string chi dung cho class nay
            ConnectionString = configuration.GetConnectionString("DefaultConnection");

            this._configuration = configuration;
        }
        public CResponseMessage Insert(CNews news)
        {
            return null;
        }

    }
}
