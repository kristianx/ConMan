#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddGrad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c2289174f110fe56ddefa5318ff5b8f2f0948fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vlasnik_AddGrad), @"mvc.1.0.view", @"/Views/Vlasnik/AddGrad.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2289174f110fe56ddefa5318ff5b8f2f0948fc", @"/Views/Vlasnik/AddGrad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Vlasnik_AddGrad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Grad>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddGrad.cshtml"
  
    ViewData["Title"] = "AddGrad";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Dodajte grad u kome se nalazi vas HQ:</h2>\n");
#nullable restore
#line 7 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddGrad.cshtml"
 using (Html.BeginForm("AddGrad","Vlasnik", FormMethod.Post))
{
    
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddGrad.cshtml"
Write(Html.TextBoxFor(m => m.Naziv, new { @placeholder="Unesite naziv grada:"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 11 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddGrad.cshtml"
Write(Html.DropDownListFor(m=>m.DrzavaId,ViewBag.D as SelectList,"Drzava"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n    <input type=\"submit\" value=\"Sacuvaj\" />\n");
            WriteLiteral("    <a href=\"/Vlasnik/AddUred\">Dalje</a>\n");
#nullable restore
#line 15 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddGrad.cshtml"
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
