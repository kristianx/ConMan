#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc7110c644f916d39d8a0027bf1c3495caadd32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poslovodja_PredracunDetalji), @"mvc.1.0.view", @"/Views/Poslovodja/PredracunDetalji.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc7110c644f916d39d8a0027bf1c3495caadd32", @"/Views/Poslovodja/PredracunDetalji.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Poslovodja_PredracunDetalji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.Models.PredracunDetaljiVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
  
    ViewData["Title"] = "PredracunDetalji";

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 94, "\"", 148, 2);
            WriteAttributeValue("", 101, "/Poslovodja/DetaljiProjekta?id=", 101, 31, true);
#nullable restore
#line 5 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
WriteAttributeValue("", 132, Model.ProjektID, 132, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""fa fa-arrow-left"" aria-hidden=""true""></a><br />

<label>Materijali na predracunu:</label>
<table class=""table table-bordered"">
    <tr>
        <th>Naziv materijala</th>
        <th>Tip materijala</th>
        <th>Mjerna jedinica</th>
        <th>Kolicina</th>
        <th>Cijena u KM(konvertibilne marke)</th>
        <th>Akcija</th>
        

    </tr>
");
#nullable restore
#line 19 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
     foreach (var x in Model.rows)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 22 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
           Write(x.MaterijalNaziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
           Write(x.GrupaMaterijalaNaziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
           Write(x.OznakaMjerneJedinice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
           Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
           Write(x.MaterijalCijena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a class=\"btn btn-primary btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 821, "\"", 925, 4);
            WriteAttributeValue("", 828, "/Poslovodja/UkloniPredracunStavku?predracunid=", 828, 46, true);
#nullable restore
#line 27 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
WriteAttributeValue("", 874, Model.PredracunID, 874, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 892, "&stavkaid=", 892, 10, true);
#nullable restore
#line 27 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
WriteAttributeValue("", 902, x.PredracunMaterijalId, 902, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\n        </tr>\n");
#nullable restore
#line 29 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n\n        <th>Ukupna cijena predracuna: ");
#nullable restore
#line 33 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
                                 Write(Model.UkupnaCijenaPredracuna);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</th>\n    </tr>\n</table><br /><br />\n              <a");
            BeginWriteAttribute("href", " href=\"", 1097, "\"", 1150, 2);
            WriteAttributeValue("", 1104, "/Poslovodja/DownloadFile?id=", 1104, 28, true);
#nullable restore
#line 36 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
WriteAttributeValue("", 1132, Model.PredracunID, 1132, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Report Excel\">Open in Excel</a><br />\n<a");
            BeginWriteAttribute("href", " href=\"", 1199, "\"", 1275, 2);
            WriteAttributeValue("", 1206, "/Poslovodja/PregledDostupnihMaterijala?predracunid=", 1206, 51, true);
#nullable restore
#line 37 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PredracunDetalji.cshtml"
WriteAttributeValue("", 1257, Model.PredracunID, 1257, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-block\">Pregled dostupnih materijala</a>\n<br /><br />\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.Models.PredracunDetaljiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591