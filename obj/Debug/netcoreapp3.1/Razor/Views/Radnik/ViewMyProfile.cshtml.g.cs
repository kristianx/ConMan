#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Radnik\ViewMyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ec30f4994338bf9495635c1b3f989ab26ee5356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Radnik_ViewMyProfile), @"mvc.1.0.view", @"/Views/Radnik/ViewMyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec30f4994338bf9495635c1b3f989ab26ee5356", @"/Views/Radnik/ViewMyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Radnik_ViewMyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.Models.RadnikViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\krist\Desktop\ConManApp\Views\Radnik\ViewMyProfile.cshtml"
  
    ViewData["Title"] = "ViewMyProfile";


#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"fa fa-arrow-left\" aria-hidden=\"true\" href=\"/Radnik/Index\"></a><br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ec30f4994338bf9495635c1b3f989ab26ee53563388", async() => {
                WriteLiteral("\n    <table class=\"table table-bordered\">\n\n        <tr>\n            <th>\n                Ime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 17 "C:\Users\krist\Desktop\ConManApp\Views\Radnik\ViewMyProfile.cshtml"
           Write(Model.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Prezime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 25 "C:\Users\krist\Desktop\ConManApp\Views\Radnik\ViewMyProfile.cshtml"
           Write(Model.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Korisnicko ime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 33 "C:\Users\krist\Desktop\ConManApp\Views\Radnik\ViewMyProfile.cshtml"
           Write(Model.username);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Password:\n            </th>\n            <td>\n                ");
#nullable restore
#line 41 "C:\Users\krist\Desktop\ConManApp\Views\Radnik\ViewMyProfile.cshtml"
           Write(Model.password);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Kontakt broj:\n            </th>\n            <td>\n                ");
#nullable restore
#line 49 "C:\Users\krist\Desktop\ConManApp\Views\Radnik\ViewMyProfile.cshtml"
           Write(Model.KontaktBroj);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n\n    </table><br />\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.Models.RadnikViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591