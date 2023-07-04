using BaseDataLib.Implementations;
using CommonLib.Implementations;
using CommonLib.Interfaces;
using CoreLib.Config;
using CoreLib.Entities;
using Dapper;
using DataServiceLib.Interfaces;
using Microsoft.Extensions.Configuration;
using NPOI.SS.Formula.Functions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataServiceLib.Implementations
{
  
    public class CProductDataProvider : CBaseDataProvider, IProductDataProvider
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
        public CProductDataProvider(IConfiguration configuration, ISerilogProvider serilogProvider)
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
        /// 
        SqlParameter[] getValues(CoreLib.Entities.Product product,bool IsInsert)
        {
            if (IsInsert == true)
            {
                return new[]
                {
                     new SqlParameter()
                       {
                                ParameterName = "@ProductName",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.NVarChar,
                                Value = product.ProductName,
                                Size=100
                       }, new SqlParameter()
                       {
                                ParameterName = "@Description",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.NVarChar,
                                Value = product.Description,
                                Size=100
                       }, new SqlParameter()
                       {
                                ParameterName = "@IdCategory",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.Int,
                                Value = product.IdCategory,
                       }, new SqlParameter()
                       {
                                ParameterName = "@Quantity",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.Int,
                                Value = product.Quantity,
                       }
                };
            }
            else
            {
                return new[]
                {
                     new SqlParameter()
                       {
                                ParameterName = "@ProductName",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.NVarChar,
                                Value = product.ProductName,
                                Size=100
                       }, new SqlParameter()
                       {
                                ParameterName = "@Description",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.NVarChar,
                                Value = product.Description,
                                Size=100
                       }, new SqlParameter()
                       {
                                ParameterName = "@IdCategory",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.Int,
                                Value = product.IdCategory,
                       }, new SqlParameter()
                       {
                                ParameterName = "@Id",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.Int,
                                Value = product.Id,
                       }, new SqlParameter()
                       {
                                ParameterName = "@Quantity",
                                Direction = ParameterDirection.Input,
                                SqlDbType = SqlDbType.Int,
                                Value = product.Quantity,
                       }
                };
            }
        }
        public CResponseMessage Insert(CoreLib.Entities.Product product)
        {

            CBaseDataProvider objSQL = new CBaseDataProvider(_serilogProvider);
            CResponseMessage cResponse = new CResponseMessage();
            try
            {

                #region Khai báo tham số cho thủ tục
                var sp_Params = getValues(product, true);

                #endregion
                cResponse = objSQL.GetResponseFromExecutedSP(SPRoute.sp_Product_Insert, sp_Params, _m_ConnectionString);
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


        public CResponseMessage Update(CoreLib.Entities.Product product)
        {

            CBaseDataProvider objSQL = new CBaseDataProvider(_serilogProvider);
            CResponseMessage cResponse = new CResponseMessage();
            try
            {
                //await sqlConnection.OpenAsync();
                #region Khai báo tham số cho thủ tục

                var sp_Params =getValues(product, false);


                #endregion
                cResponse = objSQL.GetResponseFromExecutedSP(SPRoute.sp_Product_Update, sp_Params, _m_ConnectionString);
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

        /// <summary>
        /// Xóa danh mục tin
        /// ChienND : 02-08-2021 2:29 PM
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public CResponseMessage Delete(int Id)
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
                        Value = Id,
                    }                   
                };


                #endregion
                cResponse = objSQL.GetResponseFromExecutedSP(SPRoute.sp_Product_Delete, sp_Params, _m_ConnectionString);
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

        //public CResponseMessage GetProducts()
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Tìm kiếm danh mục tin
        /// ChienND : 02-08-2021 2:29 PM
        /// </summary>
        /// <param name="catalogs"></param>
        /// <returns></returns>
        public CResponseMessage GetProducts(CCatalogs catalogs)
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

        public CResponseMessage Search(CoreLib.Entities.Product product)
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
                        ParameterName = "@ProductName",
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.NVarChar,
                        Value = product.ProductName,
                        Size=100
                    }
                };


                #endregion
                cResponse.Data = objSQL.GetDatasetFromSP(SPRoute.sp_Product_FindByName, sp_Params, _m_ConnectionString);
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

        public CResponseMessage GetOne(int Id)
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
                        Value = Id,
                    }
                };


                #endregion
                cResponse.Data = objSQL.GetDatasetFromSP(SPRoute.sp_Product_FindOne, sp_Params, _m_ConnectionString);
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

        public CResponseMessage GetAllCategories()
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
                cResponse.Data = objSQL.GetDatasetFromSP(SPRoute.sp_Category_Select, sp_Params, _m_ConnectionString);
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
