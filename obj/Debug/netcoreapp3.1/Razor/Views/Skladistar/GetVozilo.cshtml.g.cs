#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Skladistar\GetVozilo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3d99544577dd834cdd49e4c8519d1e35e2edc9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skladistar_GetVozilo), @"mvc.1.0.view", @"/Views/Skladistar/GetVozilo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d99544577dd834cdd49e4c8519d1e35e2edc9b", @"/Views/Skladistar/GetVozilo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Skladistar_GetVozilo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Vozilo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\GetVozilo.cshtml"
  
    ViewData["Title"] = "GetVozilo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>GetVozilo</h2>\n<p>Unesite ID vozila:</p>\n");
#nullable restore
#line 8 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\GetVozilo.cshtml"
 using (Html.BeginForm("ViewVozilo","Skladistar",new {username=ViewBag.username },FormMethod.Get))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\GetVozilo.cshtml"
Write(Html.DropDownListFor(m=>m.VoziloId,ViewBag.vozila as SelectList,"Vozila"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Trazi\" />\n");
#nullable restore
#line 13 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\GetVozilo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<a href=\"/Skladistar/Index\">Back to menu</a>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Vozilo> Html { get; private set; }
    }
}
#pragma warning restore 1591
