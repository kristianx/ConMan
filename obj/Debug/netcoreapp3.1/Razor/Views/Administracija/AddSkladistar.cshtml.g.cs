#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5258fe3fa53a4db5e93ce42116f070b2d68743b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administracija_AddSkladistar), @"mvc.1.0.view", @"/Views/Administracija/AddSkladistar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5258fe3fa53a4db5e93ce42116f070b2d68743b", @"/Views/Administracija/AddSkladistar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administracija_AddSkladistar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Skladistar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
  
    ViewData["Title"] = "AddSkladistar";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n\n    #tekst {\n        display: none;\n        color: red;\n    }\n\n    .plista:hover #tekst {\n        display: inline-block;\n    }\n</style>\n<h2>AddSkladistar</h2>\n\n");
#nullable restore
#line 18 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
 using (Html.BeginForm("AddSkladistar", "Administracija", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"plista\">\n    ");
#nullable restore
#line 21 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
Write(Html.TextBoxFor(m => m.Ime, new { @placeholder = "Ime" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 22 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
Write(Html.ValidationMessageFor(m => m.Ime, "Unesite ime", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n    ");
#nullable restore
#line 23 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
Write(Html.TextBoxFor(m => m.Prezime, new { @placeholder = "Prezime" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n    ");
#nullable restore
#line 24 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
Write(Html.TextBoxFor(m => m.username, new { @placeholder = "Username" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n    ");
#nullable restore
#line 25 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
Write(Html.TextBoxFor(m => m.password, new { @placeholder = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n    ");
#nullable restore
#line 26 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
Write(Html.TextBoxFor(m => m.KontaktBroj, new { @placeholder = "Broj format xxx/xxx-xxx(x)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n    ");
#nullable restore
#line 28 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"
Write(Html.DropDownListFor(m => m.SkladisteId, ViewBag.skladisteBag as SelectList, "Odaberi skladiste"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <p id=\"tekst\">Defaultna vrijednost je postavljena na prvi element liste.</p>\n</div>\n    <input type=\"submit\" value=\"Sacuvaj\">\n");
#nullable restore
#line 32 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddSkladistar.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Skladistar> Html { get; private set; }
    }
}
#pragma warning restore 1591
