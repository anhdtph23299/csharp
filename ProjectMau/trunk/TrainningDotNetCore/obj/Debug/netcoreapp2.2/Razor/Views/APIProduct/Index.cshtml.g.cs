#pragma checksum "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\APIProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e18b2231926fe6e725cb36fd3e6938c99155694f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_APIProduct_Index), @"mvc.1.0.view", @"/Views/APIProduct/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/APIProduct/Index.cshtml", typeof(AspNetCore.Views_APIProduct_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\_ViewImports.cshtml"
using EzSearchInternal;

#line default
#line hidden
#line 2 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\_ViewImports.cshtml"
using EzSearchInternal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18b2231926fe6e725cb36fd3e6938c99155694f", @"/Views/APIProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1eb15af77138a3dc26f94de69807c8d3d2e074e", @"/Views/_ViewImports.cshtml")]
    public class Views_APIProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ProductForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\APIProduct\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(119, 2244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e18b2231926fe6e725cb36fd3e6938c99155694f4422", async() => {
                BeginContext(156, 2200, true);
                WriteLiteral(@"
        <div class=""col-8"">
            <h4>Product manager</h4>
            <hr class=""bg-danger border-2 border-top border-danger mt-4"" />
            <div class=""form-floating mb-3"">
                <input type=""text""
                       class=""form-control thongtin rounded-4""
                       id=""txtProductName""
                       name=""productName""
                       placeholder=""name"" />
                <label for=""floatingInput"">Name</label>
            </div>
            <div class=""form-floating mb-3"">
                <input type=""text""
                       class=""form-control thongtin rounded-4""
                       id=""txtDescription""
                       name=""description""
                       placeholder=""description"" />
                <label for=""floatingInput"">Description</label>
            </div>
            <div class=""form-floating mb-3"">
                <input type=""text""
                       class=""form-control thongtin rounded-4""
      ");
                WriteLiteral(@"                 id=""txtQuantity""
                       name=""quantity""
                       placeholder=""Quantity"" />
                <label for=""floatingInput"">Number in Stock</label>
            </div>
            <div class=""form-floating mb-3"">
                <select class=""form-select thongtin""
                        id=""cboIdCategory""
                        name=""idCategory""
                        aria-label=""Floating label select example""></select>
                <!-- <input
                  class=""form-control thongtin rounded-4""
                  id=""txtIdCategory""
                  placeholder=""Category""
                  asp-for=""product.IdCategory""
                /> -->
                <label for=""floatingSelect"">Category</label>
            </div>

            <button type=""button""
                    class=""btn btn-outline-secondary mb-3""
                    id=""btnSave"">
                Save
            </button>
            <button type=""button""
            ");
                WriteLiteral("        class=\"btn btn-outline-secondary mb-3\"\r\n                    id=\"btnUpdate\">\r\n                Update\r\n            </button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2363, 8497, true);
            WriteLiteral(@"

    <table class=""table table-striped"" id=""datatable"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Product Name</th>
                <th scope=""col"">Quantity</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Category</th>
                <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>
<script src=""/assets/vendors/general/popper.js/dist/umd/popper.js""
        type=""text/javascript""></script>
<script src=""/assets/vendors/general/perfect-scrollbar/dist/perfect-scrollbar.js""
        type=""text/javascript""></script>
<script src=""/assets/vendors/general/sticky-js/dist/sticky.min.js""
        type=""text/javascript""></script>
<script src=""/assets/vendors/general/jquery/dist/jquery.min.js""
        type=""text/javascript""></script>
<script src=""/assets/demo/demo3/base/scripts.bundle.min.js""
        type=""text/javascript""></script>
<script s");
            WriteLiteral(@"rc=""/js/jquery-ajax-native.js""></script>
<script src=""/assets/vendors/custom/datatables/datatables.bundle.min.js""
        type=""text/javascript""></script>
<script src=""/assets/vendors/general/sweetalert2/dist/sweetalert2.js""
        type=""text/javascript""></script>

<script src=""/js/site.js""></script>
<script>
    var id = -1;
    var dataTable = null; // Biến để lưu trữ đối tượng DataTable

    $.fn.serializeObject = function () {
        var o = {};
        var a = this.serializeArray();
        $.each(a, function () {
            if (o[this.name]) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || """");
            } else {
                o[this.name] = this.value || """";
            }
        });
        return o;
    };
    var url = ""https://localhost:7029/api/Product"";
    //// Hàm để reload lại toàn bộ DataTable
    function reloadDataTable() {
        dataTable.des");
            WriteLiteral(@"troy();
        getAll();
    }
    $(""#btnSave"").click(function () {
        var formData = $(""form"").serializeObject();
        var jsonData = JSON.stringify(formData);

        console.log(jsonData);
        //Hiển thị ảnh loadding
        $(""#loading"").addClass(""loading"");
        $.ajax(url + ""/addproduct"", {
            type: ""post"",
            contentType: ""application/json"",
            data: jsonData,
        })
            .done(function (data) {
                // data.code : 0 - Không có lỗi trả về
                displayResponse(data) // Hiện thị popup thông báo kết quả
                    .then(function () {
                        // Thực hiện các hàm sau khi thông báo được đóng
                        if (data.code == 0) {
                            resetform(); // Reset Form dữ liệu
                            reloadDataTable(); // Reload DataTable
                        }
                    });
            })
            .fail(function () {
                show");
            WriteLiteral(@"Error(""Có lỗi xảy ra"");
            });
        id = -1;
        //Xóa ảnh loading
        $(""#loading"").removeClass(""loading"");
        //$('.nav-item a[href=""#k_tabs_1""]').tab(""show"");
    });

    $(""#btnUpdate"").click(function () {
        if (id == -1) {
            showError(""Chưa chọn sản phẩm cần sửa"");
            return;
        }
        var formData = $(""form"").serializeObject();
        var jsonData = JSON.stringify(formData);

        console.log(jsonData);
        //Hiển thị ảnh loadding
        $(""#loading"").addClass(""loading"");
        $.ajax(url + ""/updateproduct"" + ""/"" + id, {
            type: ""PUT"",
            contentType: ""application/json"",
            data: jsonData,
        })
            .done(function (data) {
                //data.code : 0 - Không có lỗi trả về
                displayResponse(data) // Hiện thị popup thông báo kết quả
                    .then(function () {
                        // Thực hiện các hàm sau khi thông báo được đóng
      ");
            WriteLiteral(@"                  if (data.code == 0) {
                            resetform(); // Reset Form dữ liệu
                            reloadDataTable(); // Reload DataTable
                        }
                    });
            })
            .fail(function () {
                showError(""Có lỗi xảy ra"");
            });
        //Xóa ảnh loading
        id = -1;
        $(""#loading"").removeClass(""loading"");
        $('.nav-item a[href=""#k_tabs_1""]').tab(""show"");
    });

    $(""#datatable"").on(""click"", "".button-delete"", function () {
        var value = $(this).val();
        //    //Hiển thị ảnh loadding
        $(""#loading"").addClass(""loading"");
        $.ajax(url + ""/deleteproduct/"" + value)
            .done(function (data) {
                //data.code : 0 - Không có lỗi trả về
                displayResponse(data) // Hiện thị popup thông báo kết quả
                    .then(function () {
                        // Thực hiện các hàm sau khi thông báo được đóng
             ");
            WriteLiteral(@"           if (data.code == 0) {
                            resetform(); // Reset Form dữ liệu
                            reloadDataTable(); // Reload DataTable
                        }
                    });
            })
            .fail(function () {
                showError(""Có lỗi xảy ra"");
            });
        //Xóa ảnh loading
        $(""#loading"").removeClass(""loading"");
        $('.nav-item a[href=""#k_tabs_1""]').tab(""show"");
        id = -1;

        // Thực hiện các thao tác xử lý cho button 1
    });
    $(""#datatable"").on(""click"", "".button-detail"", function () {
        var value = $(this).val();
        id = value;
        //    //Hiển thị ảnh loadding
        //$('#loading').addClass('loading');
        $.ajax(url + ""/detailproduct/"" + value)
            .done(function (data) {
                var product = data;
                console.log(data);
                $(""#txtProductName"").val(product.productName);
                $(""#txtDescription"").val(product.de");
            WriteLiteral(@"scription);
                $(""#txtQuantity"").val(product.quantity);
                $(""#cboIdCategory"").val(product.idCategory);
            })
            .fail(function () {
                showError(""Có lỗi xảy ra"");
            });
    });
    function resetform() {
        $(""#ProductForm"").trigger(""reset"");
    }
    function showSelectCategories() {
        $.get(url + ""/categories"").done(function (response) {
            var tableBody = $(""#cboIdCategory"");
            tableBody.empty();
            var html = """";
            var list = response;
            for (var i = 0; i < list.length; i++) {
                html += `
                                         <option value=""${list[i].id}"">${list[i].categoryName}</option>
                                        `;
            }
            tableBody.append(html);
        });
    }

    function getAll() {
        var ProductName = """";
        $.get(url + ""/products"").done(function (response) {
            console.log(r");
            WriteLiteral(@"esponse);
            dataTable = $(""#datatable"").DataTable({
                data: response, // Dữ liệu trả về từ server
                columns: [
                    { data: ""id"" },
                    { data: ""productName"" },
                    { data: ""quantity"" },
                    { data: ""description"" },
                    { data: ""categoryName"" },
                    {
                        data: ""id"",
                        title: ""Hành động"",
                        render: function (data, type, row) {
                            return (
                                `
                                                            <button type=""button"" value=""` +
                                data +
                                `"" class=""btn btn-outline-primary button-detail"">Detail</button>
                                                                    <button type=""button"" value=""` +
                                data +
                                `"" cla");
            WriteLiteral(@"ss=""btn btn-outline-primary button-delete"">Delete</button>
                                            `
                            );
                        },
                    },
                ],
            });
        });
    }
    getAll();
    showSelectCategories();
</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
