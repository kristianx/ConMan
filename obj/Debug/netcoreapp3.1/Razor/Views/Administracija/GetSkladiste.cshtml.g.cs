#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Administracija\GetSkladiste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db005d1c46ec902ad2f614a011c1b5f31995a975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administracija_GetSkladiste), @"mvc.1.0.view", @"/Views/Administracija/GetSkladiste.cshtml")]
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
#line 1 "C:\Users\krist\Desktop\ConManApp\Views\_ViewImports.cshtml"
using ConManApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\_ViewImports.cshtml"
using ConManApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db005d1c46ec902ad2f614a011c1b5f31995a975", @"/Views/Administracija/GetSkladiste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administracija_GetSkladiste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Skladiste>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\GetSkladiste.cshtml"
  
    ViewData["Title"] = "GetSkladiste";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>GetSkladiste</h2>\n");
#nullable restore
#line 7 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\GetSkladiste.cshtml"
 using (Html.BeginForm("ViewSkladiste", "Administracija", FormMethod.Get))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\GetSkladiste.cshtml"
Write(Html.DropDownListFor(m => m.SkladisteId, ViewBag.Skladista as SelectList, "Odaberi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Trazi\" />\n");
#nullable restore
#line 12 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\GetSkladiste.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Skladiste> Html { get; private set; }
    }
}
#pragma warning restore 1591