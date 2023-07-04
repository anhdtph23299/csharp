using CoreLib.DataTableToOject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces;
using DataTableToOject.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Data;
using TrainningDotNetCore.Models;

namespace TrainningDotNetCore.Controllers
{
    public class ProductControllerView : Controller
    {
        private readonly IProductDataProvider _IProductDataProvider ;
        public IConfiguration Configuration { get; }
        /// <summary>
        /// Chuyển đồi thôngtin Mess lỗi => Mess hiển thị.
        /// </summary>
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public ProductControllerView(IProductDataProvider productDataProvider,
           IConfiguration configuration, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            this.Configuration = configuration;
            this._IProductDataProvider = productDataProvider;
            this._sharedLocalizer = sharedLocalizer;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DetailProduct(int Id)
        {
            DataSet dataSet = new DataSet();
            IEnumerable<Product> products;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.GetOne(Id);
            string code = "0";
            //Convert Data From DataSet -> List Object
            var mapper = new DataNamesMapper<Product>();
            products = ((DataSet)cResponseMessage.Data).ToListItem<Product>();
            //-----
            var data = new { products, code };
            return this.Json(data);
        }
        public IActionResult GetAllCategory()
        {
            DataSet dataSet = new DataSet();
            IEnumerable<Category> categories;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.GetAllCategories();
            string code = "0";
            //Convert Data From DataSet -> List Object
            var mapper = new DataNamesMapper<Product>();
            categories = ((DataSet)cResponseMessage.Data).ToListItem<Category>();
            //-----
            var data = new { categories, code };
            return this.Json(data);
        }
        public IActionResult InsertProduct(ListProductViewModel model)
        {

            model.ReturnMess = _IProductDataProvider.Insert(model.product);
            model.ReturnMess.Message = this._sharedLocalizer[model.ReturnMess.Message];
            return Json(model.ReturnMess);
        }

        public IActionResult updateProduct(ListProductViewModel model, int id)
        {
            model.product.Id= id;
            model.ReturnMess = _IProductDataProvider.Update(model.product);
            model.ReturnMess.Message = this._sharedLocalizer[model.ReturnMess.Message];
            return Json(model.ReturnMess);
        }

        public IActionResult DeleteProduct(int Id)
        {
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.Delete(Id);
            cResponseMessage.Message = this._sharedLocalizer[cResponseMessage.Message];
            return this.Json(cResponseMessage);
        }
        public IActionResult SearchByProductName(string productName)
        {
            if(productName == null)
            {
                productName = "";
            }
            Product searchOptions = new Product();
            DataSet dataSet = new DataSet();
            IEnumerable<Product> products;
            searchOptions.ProductName = productName;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.Search(searchOptions);
            string code = "0";
            //Convert Data From DataSet -> List Object
            var mapper = new DataNamesMapper<Product>();
            products = ((DataSet)cResponseMessage.Data).ToListItem<Product>();
            //-----
            var data = new { products, code };
            return this.Json(data);
        }
    }
}
