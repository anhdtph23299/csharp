#pragma checksum "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e5d21a17d0639f52f1906e4c851f721626f9c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FormMessage), @"mvc.1.0.view", @"/Views/Shared/_FormMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FormMessage.cshtml", typeof(AspNetCore.Views_Shared__FormMessage))]
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
#line 1 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml"
using CoreLib.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e5d21a17d0639f52f1906e4c851f721626f9c2", @"/Views/Shared/_FormMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1eb15af77138a3dc26f94de69807c8d3d2e074e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FormMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CResponseMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 6 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml"
  
    if (Model == null)
     {
         return;
     }





#line default
#line hidden
            BeginContext(129, 546, true);
            WriteLiteral(@"
<script>
    toastr.options = {
        ""closeButton"": true,
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
</script>

");
            EndContext();
#line 37 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml"
     if (Model.Code == "1") // has error
    {

#line default
#line hidden
            BeginContext(724, 44, true);
            WriteLiteral("        <script>\r\n            toastr.error(\"");
            EndContext();
            BeginContext(769, 13, false);
#line 40 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml"
                     Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(782, 24, true);
            WriteLiteral("\");\r\n        </script>\r\n");
            EndContext();
#line 42 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml"

        

    }
    else
    {

#line default
#line hidden
            BeginContext(844, 43, true);
            WriteLiteral("        <script>\r\n            toastr.info(\"");
            EndContext();
            BeginContext(888, 13, false);
#line 49 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml"
                    Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(901, 24, true);
            WriteLiteral("\");\r\n        </script>\r\n");
            EndContext();
#line 51 "D:\thuctap\C#\ProjectMau\trunk\TrainningDotNetCore\Views\Shared\_FormMessage.cshtml"
    }

#line default
#line hidden
            BeginContext(932, 3, true);
            WriteLiteral("\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CResponseMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
