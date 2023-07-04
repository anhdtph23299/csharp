using CoreLib.DataTableToOject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces;
using DataTableToOject.Mapping;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Data;
using TrainningDotNetCore;
using TrainningDotNetCore.Models;

namespace APIProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductDataProvider _IProductDataProvider;
        public IConfiguration Configuration { get; }
        /// <summary>
        /// Chuyển đồi thôngtin Mess lỗi => Mess hiển thị.
        /// </summary>
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public ProductController(IProductDataProvider productDataProvider,
           IConfiguration configuration, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            this.Configuration = configuration;
            this._IProductDataProvider = productDataProvider;
            this._sharedLocalizer = sharedLocalizer;
        }
        [HttpGet("categories")]
        public IEnumerable<Category> getAllCategory()
        {
            DataSet dataSet = new DataSet();
            IEnumerable<Category> categories;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.GetAllCategories();
            //Convert Data From DataSet -> List Object
            var mapper = new DataNamesMapper<Product>();
            categories = ((DataSet)cResponseMessage.Data).ToListItem<Category>();
            //-----
            return categories;
        }

        [HttpGet("products")]
        public IEnumerable<Product> getAllProduct()
        {
            DataSet dataSet = new DataSet();
            Product product = new Product();
            product.ProductName = "";
            IEnumerable<Product> products;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.Search(product);
            //Convert Data From DataSet -> List Object
            var mapper = new DataNamesMapper<Product>();
            products = ((DataSet)cResponseMessage.Data).ToListItem<Product>();
            //-----
            return products;
        }

        [HttpGet("detailproduct/{id}")]
        public Product DetailProduct(int id)
        {
            DataSet dataSet = new DataSet();
            IEnumerable<Product> products;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.GetOne(id);
            string code = "0";
            //Convert Data From DataSet -> List Object
            products = ((DataSet)cResponseMessage.Data).ToListItem<Product>();
            //-----
            return products.ElementAt(0);
        }

        [HttpGet("findproduct")]
        public IEnumerable<Product> findProduct(string productName)
        {
            DataSet dataSet = new DataSet();
            Product product = new Product();
            product.ProductName = productName;
            IEnumerable<Product> products;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.Search(product);
            //Convert Data From DataSet -> List Object
            products = ((DataSet)cResponseMessage.Data).ToListItem<Product>();
            //-----
            return products;
        }

        [HttpPost("addproduct")]
        public object InsertProduct(Product product)
        {
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.Insert(product);
            cResponseMessage.Message = this._sharedLocalizer[cResponseMessage.Message];
            var mess = new { cResponseMessage.Code, cResponseMessage.Message };
            return mess;
        }
        [HttpPut("updateproduct/{id}")]
        public object UpdateProduct(Product product,int id)
        {
            product.Id= id;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.Update(product);
            cResponseMessage.Message = this._sharedLocalizer[cResponseMessage.Message];
            var mess = new { cResponseMessage.Code, cResponseMessage.Message };
            return mess;
        }
        [HttpDelete("deleteproduct/{id}")]
        public object Delete(int id)
        {
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _IProductDataProvider.Delete(id);
            cResponseMessage.Message = this._sharedLocalizer[cResponseMessage.Message];
            var mess = new { cResponseMessage.Code,cResponseMessage.Message};
            return mess;
        }

    }
}
