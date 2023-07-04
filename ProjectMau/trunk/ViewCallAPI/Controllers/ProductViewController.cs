using CoreLib.Entities;

using Microsoft.AspNetCore.Mvc;

using System.Text;
using static OfficeOpenXml.ExcelErrorValue;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ViewCallAPI.Controllers
{
    public class ProductViewController : Controller
    {
      //  private ProductController productController;
         private readonly HttpClient _httpClient;

        public ProductViewController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetAllCategory()
        {
            var response = await _httpClient.GetAsync("https://localhost:7029/api/Product/categories");


            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Trả về dữ liệu từ API
                return Content(content, "application/json");
            }
            else
            {
                return StatusCode((int)response.StatusCode); // Trả về mã lỗi tương ứng
            }
        }
        public async Task<IActionResult> DetailProduct(int Id)
        {

            var response = await _httpClient.GetAsync("https://localhost:7029/api/Product/detailproduct/" + Id);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Trả về dữ liệu từ API
                return Content(content, "application/json");
            }
            else
            {
                return StatusCode((int)response.StatusCode); // Trả về mã lỗi tương ứng
            }
        }

        public async Task<IActionResult> getAllProduct()
        {
            var response = await _httpClient.GetAsync("https://localhost:7029/api/Product/products");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Trả về dữ liệu từ API
                return Content(content, "application/json");
            }
            else
            {
                return StatusCode((int)response.StatusCode); // Trả về mã lỗi tương ứng
            }
        }
        public async Task<IActionResult> InsertProduct(Product product)
        {
            var productJson = JsonSerializer.Serialize(product);

            HttpContent values = new StringContent(productJson, Encoding.UTF8, "application/json");

            string apiUrl = "https://localhost:7029/api/Product/addproduct";

            var response = await _httpClient.PostAsync(apiUrl, values);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Trả về dữ liệu từ API
                return Content(content, "application/json");
            }
            else
            {
                return StatusCode((int)response.StatusCode); // Trả về mã lỗi tương ứng
            }
        }


        public async Task<IActionResult> UpdateProduct(Product product, int id)
        {
            var productJson = JsonSerializer.Serialize(product);

            HttpContent values = new StringContent(productJson, Encoding.UTF8, "application/json");

            string apiUrl = "https://localhost:7029/api/Product/updateproduct/"+id;

            var response = await _httpClient.PutAsync(apiUrl, values);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Trả về dữ liệu từ API
                return Content(content, "application/json");
            }
            else
            {
                return StatusCode((int)response.StatusCode); // Trả về mã lỗi tương ứng
            }

        }

        public async Task<IActionResult> DeleteProduct(int Id)
        {

            string apiUrl = "https://localhost:7029/api/Product/deleteproduct/" + Id;

            var response = await _httpClient.DeleteAsync(apiUrl);

            var responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Trả về dữ liệu từ API
                return Content(content, "application/json");
            }
            else
            {
                return StatusCode((int)response.StatusCode); // Trả về mã lỗi tương ứng
            }

        }
    }
}
