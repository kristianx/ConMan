#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddGrad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11c61edefe7a786ee17640d59d17ce8334d6e42b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administracija_AddGrad), @"mvc.1.0.view", @"/Views/Administracija/AddGrad.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11c61edefe7a786ee17640d59d17ce8334d6e42b", @"/Views/Administracija/AddGrad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administracija_AddGrad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Grad>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddGrad.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Add Grad</h2>\n");
#nullable restore
#line 7 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddGrad.cshtml"
 using (Html.BeginForm("AddGrad", "Administracija", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddGrad.cshtml"
Write(Html.DropDownListFor(m => m.DrzavaId, ViewBag.D as SelectList, "--select--"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/Administracija/AddDrzava\">...</a><br />\n");
#nullable restore
#line 10 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddGrad.cshtml"
Write(Html.TextBoxFor(m => m.Naziv, new { @placeholder = "Unesite naziv grada:" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Sacuvaj\" />\n    <a href=\"/Administracija/AddUred\">Back to previous</a>\n");
#nullable restore
#line 14 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddGrad.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Grad> Html { get; private set; }
    }
}
#pragma warning restore 1591
