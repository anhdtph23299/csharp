#pragma checksum "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa0ce994ba7397337b49e52fa664d89c1236480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FormMessageImportExcel), @"mvc.1.0.view", @"/Views/Shared/_FormMessageImportExcel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FormMessageImportExcel.cshtml", typeof(AspNetCore.Views_Shared__FormMessageImportExcel))]
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
#line 1 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml"
using CoreLib.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa0ce994ba7397337b49e52fa664d89c1236480", @"/Views/Shared/_FormMessageImportExcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1eb15af77138a3dc26f94de69807c8d3d2e074e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FormMessageImportExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CResponseMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml"
 if (Model.Code == "0")
{

#line default
#line hidden
            BeginContext(80, 630, true);
            WriteLiteral(@"    <script>
        toastr.options = {
            ""closeButton"": false,
            ""debug"": false,
            ""newestOnTop"": false,
            ""progressBar"": false,
            ""positionClass"": ""toast-bottom-right"",
            ""preventDuplicates"": false,
            ""onclick"": null,
            ""showDuration"": ""300"",
            ""hideDuration"": ""1000"",
            ""timeOut"": ""20000"",
            ""extendedTimeOut"": ""1000"",
            ""showEasing"": ""swing"",
            ""hideEasing"": ""linear"",
            ""showMethod"": ""fadeIn"",
            ""hideMethod"": ""fadeOut""
        };

        toastr.success(""");
            EndContext();
            BeginContext(711, 13, false);
#line 25 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml"
                   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(724, 20, true);
            WriteLiteral("\");\r\n    </script>\r\n");
            EndContext();
#line 27 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml"
}

#line default
#line hidden
            BeginContext(747, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml"
 if (Model.Code == "-1")
{

#line default
#line hidden
            BeginContext(778, 628, true);
            WriteLiteral(@"    <script>
        toastr.options = {
            ""closeButton"": false,
            ""debug"": false,
            ""newestOnTop"": false,
            ""progressBar"": false,
            ""positionClass"": ""toast-bottom-right"",
            ""preventDuplicates"": false,
            ""onclick"": null,
            ""showDuration"": ""300"",
            ""hideDuration"": ""1000"",
            ""timeOut"": ""20000"",
            ""extendedTimeOut"": ""1000"",
            ""showEasing"": ""swing"",
            ""hideEasing"": ""linear"",
            ""showMethod"": ""fadeIn"",
            ""hideMethod"": ""fadeOut""
        };

        toastr.error(""");
            EndContext();
            BeginContext(1407, 13, false);
#line 50 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml"
                 Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1420, 20, true);
            WriteLiteral("\");\r\n    </script>\r\n");
            EndContext();
#line 52 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessageImportExcel.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CResponseMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
