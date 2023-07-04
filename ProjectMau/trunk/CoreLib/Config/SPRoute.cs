namespace CoreLib.Config
{
    /// <summary>
    /// Định nghĩa tất cả các sp.
    /// </summary>
    public class SPRoute
    {
        // News
        public const string SP_News_Insert = "sp_News_Insert";
        public const string sp_News_Update = "sp_News_Update";
        public const string sp_News_Delete = "sp_News_Delete";
        public const string sp_News_Search = "sp_News_Search";
        // Catalogs
        public const string sp_Catalogs_Delete = "sp_Catalogs_Delete";
        public const string sp_Catalogs_Insert = "sp_Catalogs_Insert";
        public const string sp_Catalogs_Search = "sp_Catalogs_Search";
        public const string sp_Catalogs_Update = "sp_Catalogs_Update";

        //Product
        public const string sp_Product_Insert = "sp_Product_Insert";
        public const string sp_Product_FindByName = "FindByProductName";
        public const string sp_Product_Update = "sp_Product_Update";
        public const string sp_Product_Delete = "sp_Product_Delete";
        public const string sp_Product_FindOne = "sp_Product_FindOne";

        //Category
        public const string sp_Category_Select = "sp_Category_Select";
        //DanhMuc
        public const string sp_DanhMuc_FindAll = "sp_DanhMuc_FindAll";

        //TieuChi
        public const string sp_TieuChi_FindAll = "sp_TieuChi_FindAll";



    }
}
