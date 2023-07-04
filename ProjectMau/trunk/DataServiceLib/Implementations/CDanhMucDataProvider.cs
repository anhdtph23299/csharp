using BaseDataLib.Implementations;
using CommonLib.Interfaces;
using CoreLib.Config;
using CoreLib.Entities;
using DataServiceLib.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DataServiceLib.Implementations
{
    public class CDanhMucDataProvider : CBaseDataProvider, IDanhMucDataProvider
    {
        private readonly IConfiguration _configuration;
        private readonly ISerilogProvider _serilogProvider;
        private readonly string _m_ConnectionString;


        /// <summary>
        /// 2021-02-08 10:30:58 chiennd
        /// contructor, lay conn string, logger instance
        /// </summary>
        /// <param name="strConnectionString"></param>
        public CDanhMucDataProvider(IConfiguration configuration, ISerilogProvider serilogProvider)
            : base(serilogProvider)
        {
            // conn string chi dung cho class nay
            _m_ConnectionString = configuration.GetConnectionString("DefaultConnection");
            this._configuration = configuration;
            this._serilogProvider = serilogProvider;
        }

        public CResponseMessage getDanhMuc()
        {
            CBaseDataProvider objSQL = new CBaseDataProvider(_serilogProvider);
            CResponseMessage cResponse = new CResponseMessage();
            try
            {
                //await sqlConnection.OpenAsync();
                #region Khai báo tham số cho thủ tục

                var sp_Params = new[]
                {
                        new SqlParameter()
                    {
                        ParameterName = "@Id",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = 1,
                    }
                };


                #endregion
                cResponse.Data = objSQL.GetDatasetFromSP(SPRoute.sp_DanhMuc_FindAll, sp_Params, _m_ConnectionString);
                //     this.Logger.Debug("After connect DB -> Message:" + cResponse.Code.ToString());
            }
            catch (Exception ex)
            {
                // log error
                this.WriteToFile(ex);
                // build return obj (FAILED)

            }
            return cResponse;
        }
    }
}
