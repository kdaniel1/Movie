#pragma checksum "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a838f4e93f2fb11dfb6aaf0792e32c46e0d0a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FirstThingsFirst.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace FirstThingsFirst.Views.Home
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
#line 3 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/_ViewImports.cshtml"
using FirstThingsFirst.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/_ViewImports.cshtml"
using FirstThingsFirst.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a838f4e93f2fb11dfb6aaf0792e32c46e0d0a2e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47c35a36ccf74523c91fc415ed7acc181616a58d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuadrantViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>To Do</h3>\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-6 border border-dark\">\n            <h3>Urgent and Important</h3>\n\n            <ul>\n");
#nullable restore
#line 10 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                 foreach (var x in Model.QuandrantI)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li> ");
#nullable restore
#line 12 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                    Write(x.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n");
#nullable restore
#line 13 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n        <div class=\"col-6 border border-dark\">\n\n            <h3>Not Urgent But Important</h3>\n            <br />\n\n\n            <ul>\n");
#nullable restore
#line 23 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                 foreach (var x in Model.QuandrantII)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li> ");
#nullable restore
#line 25 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                    Write(x.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 26 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n    </div>\n    <div class=\"row\">\n\n        <div class=\"col-6 border border-dark\">\n            <h3>Urgent Not Important</h3>\n\n            <ul>\n");
#nullable restore
#line 36 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                 foreach (var x in Model.QuandrantIII)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li> ");
#nullable restore
#line 38 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                    Write(x.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n");
#nullable restore
#line 39 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n        <div class=\"col-6 border border-dark\">\n            <h3>Not Urgent Not Important</h3>\n\n            <ul>\n");
#nullable restore
#line 46 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                 foreach (var x in Model.QuandrantIV)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li> ");
#nullable restore
#line 48 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                    Write(x.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n");
#nullable restore
#line 49 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n    </div>\n</div>\n\n\n\n\n\n\n<p>List of Tasks</p>\n\n<ul>\n");
#nullable restore
#line 63 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
 foreach (var x in Model.QuandrantI)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 65 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
   Write(x.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 66 "/Users/kennedydaniel/Projects/FirstThingsFirst/FirstThingsFirst/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuadrantViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
