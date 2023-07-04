using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLib.Config;
using Microsoft.AspNetCore.Mvc;
using TrainningDotNetCore.Models;
using Microsoft.Extensions.Configuration;
using DataServiceLib.Interfaces;
using CoreLib.Entities;
using Microsoft.Extensions.Localization;
using DataTableToOject.Mapping;
using System.Data;
using CoreLib.DataTableToOject.Mapping;

namespace TrainningDotNetCore.Controllers
{

    public class CatalogsController : Controller
    {
        //private readonly ICatalogDataProvider _ICatalogDataProvider;
        //public IConfiguration Configuration { get; }

        /// <summary>
        /// Chuyển đồi thôngtin Mess lỗi => Mess hiển thị.
        /// </summary>
        //private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        //public CatalogsController(ICatalogDataProvider catalogDataProvider,
        //   IConfiguration configuration, IStringLocalizer<SharedResource> sharedLocalizer)
        //{
        //    this.Configuration = configuration;
        //    this._ICatalogDataProvider = catalogDataProvider;
        //    this._sharedLocalizer = sharedLocalizer;
        //}
        //[Route(LinkRoute.DanhSachCatalog)]
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult Search(string CatalogName)
        //{
        //    CCatalogs searchOptions = new CCatalogs();
        //    DataSet dataSet = new DataSet();
        //    IEnumerable<CCatalogs> listcatalogs;
        //    searchOptions.CatalogName = CatalogName;
        //    CResponseMessage cResponseMessage = new CResponseMessage();
        //    cResponseMessage = _ICatalogDataProvider.Search(searchOptions);
        //    string code = "0";
        //    Convert Data From DataSet -> List Object
        //    var mapper = new DataNamesMapper<CCatalogs>();
        //    listcatalogs = ((DataSet)cResponseMessage.Data).ToListItem<CCatalogs>();
        //    -----
        //    var data = new { listcatalogs, code };
        //    return this.Json(data);
        //}

        //[HttpGet]
        //public IActionResult GetDetail(int ID)
        //{
        //    CCatalogs searchOptions = new CCatalogs();
        //    DataSet dataSet = new DataSet();
        //    IEnumerable<CCatalogs> listcatalogs;
        //    searchOptions.ID = ID;
        //    CResponseMessage cResponseMessage = new CResponseMessage();
        //    cResponseMessage = _ICatalogDataProvider.Search(searchOptions);
        //    string code = "0";
        //    Convert Data From DataSet -> List Object
        //    var mapper = new DataNamesMapper<CCatalogs>();
        //    listcatalogs = ((DataSet)cResponseMessage.Data).ToListItem<CCatalogs>();
        //    -----
        //    var data = new { listcatalogs, code };
        //    return this.Json(data);
        //}
        //[HttpPost]
        //public IActionResult UpdateCatalogs(ListCatalogsViewModel viewModel)
        //{

        //    viewModel.ReturnMess = _ICatalogDataProvider.Update(viewModel.cCatalog);
        //    viewModel.ReturnMess.Message = this._sharedLocalizer[viewModel.ReturnMess.Message];
        //    return this.Json(viewModel.ReturnMess);
        //}
        //[HttpPost]
        //public IActionResult InsertCatalogs(ListCatalogsViewModel viewModel)
        //{
        //    viewModel.ReturnMess = _ICatalogDataProvider.Insert(viewModel.cCatalog);
        //    viewModel.ReturnMess.Message = this._sharedLocalizer[viewModel.ReturnMess.Message];
        //    return this.Json(viewModel.ReturnMess);
        //}
        //[HttpPost]
        //public IActionResult DeleteCatalogs(int ID)
        //{
        //    CResponseMessage cResponseMessage = new CResponseMessage();
        //    cResponseMessage = _ICatalogDataProvider.Delete(ID);
        //    cResponseMessage.Message = this._sharedLocalizer[cResponseMessage.Message];
        //    return this.Json(cResponseMessage);
        //}
    }


}