using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CoreLib.Entities;

namespace CoreLib.Interfaces
{
    /// <summary>
    /// 2019-02-12 12:58:49 chiennd 
    /// truy xuat db, exec sp
    /// </summary>
    public interface IDataProvider
    {
       // string GetParamInfo(DynamicParameters DP);
        bool _OpenConnection(string _m_ConnectionString);
        void _CloseConnection();
        
        DataSet GetDatasetFromSP(string SPname, IDbDataParameter[] paramArr,string _m_ConnectionString);
        SqlDataReader GetDataReaderFromSP(string SPname, IDbDataParameter[] paramArr, string _m_ConnectionString);
        bool ExecuteSP(string SPname, IDbDataParameter[] paramArr, string _m_ConnectionString);

        /// <summary>
        /// Thực thi sp , 
        /// SP tryền vào phải có 2 output parameter , 
        ///  @Message  nvarchar(200) output ,
        ///  @ErrorCode int output
        /// </summary>
        /// <param name="SPname">Tên SP</param>
        /// <param name="paramArr">Các para chứa dữ liệu</param>
        /// <param name="_m_ConnectionString">Chuỗi kết nối</param>
        /// <returns>Respose gồm mã lỗi và message </returns>
        CResponseMessage GetResponseFromExecutedSP(string SPname, IDbDataParameter[] paramArr, string _m_ConnectionString);
    }
}
