#pragma checksum "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d84eeadad8f509fb32b877566b0f81067f8eca60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\_ViewImports.cshtml"
using Team4_FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\_ViewImports.cshtml"
using Team4_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d84eeadad8f509fb32b877566b0f81067f8eca60", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac47c7cbafcf6fd9d0b6805125d13433c64e9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    #mainheader {\r\n        animation: slidedown 2s;\r\n        \r\n    }\r\n    #jumb{\r\n        overflow-y: hidden;\r\n    }\r\n</style>\r\n\r\n<div id=\"jumb\"class=\"jumbotron\">\r\n    <h1 id=\"mainheader\" class=\"text-center\">Welcome ");
#nullable restore
#line 16 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Home\Index.cshtml"
                                               Write(TempData["cu_first"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n");
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
