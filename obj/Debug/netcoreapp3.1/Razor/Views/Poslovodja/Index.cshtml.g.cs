#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9cc5a06e0c9ca4f40b8df834507cbee6de6c7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poslovodja_Index), @"mvc.1.0.view", @"/Views/Poslovodja/Index.cshtml")]
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
#line 1 "C:\Users\krist\Desktop\Keebree\Views\_ViewImports.cshtml"
using ConManApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\_ViewImports.cshtml"
using ConManApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9cc5a06e0c9ca4f40b8df834507cbee6de6c7d", @"/Views/Poslovodja/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Poslovodja_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ConManApp.EnModels.ProjektInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
  
    ViewData["Title"] = "PagePInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<nav>\n    ");
#nullable restore
#line 13 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
Write(await this.Component.InvokeAsync("Pager", new {pagingList=this.Model}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</nav>\n");
            WriteLiteral("<table class=\"table table-hover\">\n\n");
#nullable restore
#line 21 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 24 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
           Write(x.DatumKreiranja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
           Write(x.textInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 27 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<a href=\"/Poslovodja/Index1\">Back to Index</a>\n\n\n\n<nav>\n    <vc:pager");
            BeginWriteAttribute("paging-list", " paging-list=\"", 714, "\"", 734, 1);
#nullable restore
#line 35 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\Index.cshtml"
WriteAttributeValue("", 728, Model, 728, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n\n    \n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ConManApp.EnModels.ProjektInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
