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
        private readonly IDanhMucDataProvider _danhMucDataProvider;
        public IConfiguration Configuration { get; }
        /// <summary>
        /// Chuyển đồi thôngtin Mess lỗi => Mess hiển thị.
        /// </summary>
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public DanhMucThongKeController(IDanhMucDataProvider danhMucThongKeDataProvider,
           IConfiguration configuration, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            this.Configuration = configuration;
            this._danhMucDataProvider = danhMucThongKeDataProvider;
            this._sharedLocalizer = sharedLocalizer;
        }
        [HttpGet("categories")]
        public IEnumerable<DanhMuc> getAllCategory()
        {
            DataSet dataSet = new DataSet();
            IEnumerable<DanhMuc> categories;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _DanhMucThongKeDataProvider.getDanhMuc();
            //Convert Data From DataSet -> List Object
            var mapper = new DataNamesMapper<DanhMuc>();
            categories = ((DataSet)cResponseMessage.Data).ToListItem<DanhMuc>();
            //-----
            return categories;
        }

        [HttpGet("tieuchi")]
        public IEnumerable<DanhMuc> getAllTieuChi()
        {
            DataSet dataSet = new DataSet();
            IEnumerable<DanhMuc> categories;
            CResponseMessage cResponseMessage = new CResponseMessage();
            cResponseMessage = _DanhMucThongKeDataProvider.getDanhMuc();
            //Convert Data From DataSet -> List Object
            var mapper = new DataNamesMapper<DanhMuc>();
            categories = ((DataSet)cResponseMessage.Data).ToListItem<DanhMuc>();
            //-----
            return categories;
        }

    }
}
