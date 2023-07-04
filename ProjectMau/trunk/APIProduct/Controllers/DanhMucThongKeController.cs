using CoreLib.DataTableToOject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces;
using DataTableToOject.Mapping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Data;
using TrainningDotNetCore;

namespace APIProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucThongKeController : ControllerBase
    {
        private readonly IProductDataProvider _IProductDataProvider;
        public IConfiguration Configuration { get; }
        /// <summary>
        /// Chuyển đồi thôngtin Mess lỗi => Mess hiển thị.
        /// </summary>
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public DanhMucThongKeController(IProductDataProvider productDataProvider,
           IConfiguration configuration, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            this.Configuration = configuration;
            this._IProductDataProvider = productDataProvider;
            this._sharedLocalizer = sharedLocalizer;
        }
        

    }
}
