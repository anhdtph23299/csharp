using BaseDataLib.Implementations;
using CommonLib.Implementations;
using CommonLib.Interfaces;
using CoreLib.Config;
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
  
    public class CCatalogDataProvider : CBaseDataProvider, ICatalogDataProvider
    {
        // const
        private readonly IConfiguration _configuration;
        private readonly ISerilogProvider _serilogProvider;
        private readonly string _m_ConnectionString;


        /// <summary>
        /// 2021-02-08 10:30:58 chiennd
        /// contructor, lay conn string, logger instance
        /// </summary>
        /// <param name="strConnectionString"></param>
        public CCatalogDataProvider(IConfiguration configuration, ISerilogProvider serilogProvider)
            : base(serilogProvider)
        {
            // conn string chi dung cho class nay
            _m_ConnectionString = configuration.GetConnectionString("DefaultConnection");
            this._configuration = configuration;
            this._serilogProvider = serilogProvider;
        }

        /// <summary>
        /// 2021-02-08 ChienND: Thêm danh mục tin
        /// </summary>
        /// <param name="catalogs"></param>
        /// <returns></returns>
        public CResponseMessage Insert(CCatalogs catalogs)
        {

            CBaseDataProvider objSQL = new CBaseDataProvider(_serilogProvider);
            CResponseMessage cResponse = new CResponseMessage();
            try
            {
               
                #region Khai báo tham số cho thủ tục
                var sp_Params = new[]
                {
                     new SqlParameter()
                       {
                                ParameterName = "@CatalogName",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.NVarChar,
                                Value = catalogs.CatalogName,
                                Size=200
                       }, new SqlParameter()
                       {
                                ParameterName = "@Note",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.NVarChar,
                                Value = catalogs.Note,
                                Size=2000
                       }
                };

                #endregion
                cResponse = objSQL.GetResponseFromExecutedSP(SPRoute.sp_Catalogs_Insert, sp_Params, _m_ConnectionString);
                this.Logger.Debug("After connect DB -> Message:" + cResponse.Code.ToString());
            }
            catch (Exception ex)
            {
                // log error
                this.WriteToFile(ex);
                // build return obj (FAILED)

            }
            return cResponse;
        }

        /// <summary>     
        /// 2021-02-08 ChienND:Cập nhật danh mục tin
        /// </summary>
        /// <param name="catalogs"></param>
        /// <returns></returns>
        public CResponseMessage Update(CCatalogs catalogs)
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
                        ParameterName = "@ID",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = catalogs.ID,
                    },
                    new SqlParameter()
                    {
                        ParameterName = "@CatalogName",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.NVarChar,
                        Value = catalogs.CatalogName,
                        Size=200
                    }, new SqlParameter()
                    {
                        ParameterName = "@Note",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.NVarChar,
                        Value = catalogs.Note,
                        Size=2000
                    }
                };


                #endregion
                cResponse = objSQL.GetResponseFromExecutedSP(SPRoute.sp_Catalogs_Update, sp_Params, _m_ConnectionString);
                this.Logger.Debug("After connect DB -> Message:" + cResponse.Code.ToString());
            }
            catch (Exception ex)
            {
                // log error
                this.WriteToFile(ex);
                // build return obj (FAILED)

            }
            return cResponse;
        }

        /// <summary>
        /// Xóa danh mục tin
        /// ChienND : 02-08-2021 2:29 PM
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public CResponseMessage Delete(int ID)
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
                        ParameterName = "@ID",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = ID,
                    }                   
                };


                #endregion
                cResponse = objSQL.GetResponseFromExecutedSP(SPRoute.sp_Catalogs_Delete, sp_Params, _m_ConnectionString);
                this.Logger.Debug("After connect DB -> Message:" + cResponse.Code.ToString());
            }
            catch (Exception ex)
            {
                // log error
                this.WriteToFile(ex);
                // build return obj (FAILED)

            }
            return cResponse;
        }


        /// <summary>
        /// Tìm kiếm danh mục tin
        /// ChienND : 02-08-2021 2:29 PM
        /// </summary>
        /// <param name="catalogs"></param>
        /// <returns></returns>
        public CResponseMessage Search(CCatalogs catalogs)
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
                        ParameterName = "@CatalogName",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.NVarChar,
                        Value = catalogs.CatalogName,
                        Size=200
                    },
                          new SqlParameter()
                    {
                        ParameterName = "@ID",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = catalogs.ID,
                    }
                };


                #endregion
                cResponse.Data = objSQL.GetDatasetFromSP(SPRoute.sp_Catalogs_Search, sp_Params, _m_ConnectionString);
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
