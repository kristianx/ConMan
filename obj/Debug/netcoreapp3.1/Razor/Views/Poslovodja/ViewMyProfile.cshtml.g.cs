#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53791009f356bd3ea35d19ebb7b3345fc80d0a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poslovodja_ViewMyProfile), @"mvc.1.0.view", @"/Views/Poslovodja/ViewMyProfile.cshtml")]
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
#line 3 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
using ConManApp.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
using ConManApp.EnModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
using ConManApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53791009f356bd3ea35d19ebb7b3345fc80d0a8c", @"/Views/Poslovodja/ViewMyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Poslovodja_ViewMyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.Models.PoslovodjaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
   ViewData["Title"] = "ViewMyProfile"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

    <!-- Sidebar Toggle (Topbar) -->
    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
        <i class=""fa fa-bars""></i>
    </button>

    <a class=""fa fa-arrow-left back-arrow"" aria-hidden=""true"" href=""/Poslovodja/Index1""></a>

    <!-- Topbar Navbar -->
    <ul class=""navbar-nav ml-auto"">



        <!-- Nav Item - Alerts -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-bell fa-fw""></i>
                <!-- Counter - Alerts -->
                <span class=""badge badge-danger badge-counter"">3+</span>
            </a>
            <!-- Dropdown - Alerts -->
            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""alertsDropdown"">
  ");
            WriteLiteral(@"              <h6 class=""dropdown-header"">
                    Alerts Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-primary"">
                            <i class=""fas fa-file-alt text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 12, 2019</div>
                        <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-success"">
                            <i class=""fas fa-donate text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div ");
            WriteLiteral(@"class=""small text-gray-500"">December 7, 2019</div>
                        $290.29 has been deposited into your account!
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-warning"">
                            <i class=""fas fa-exclamation-triangle text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 2, 2019</div>
                        Spending Alert: We've noticed unusually high spending for your account.
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
            </div>
        </li>

        <!-- Nav Item - Messages -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""");
            WriteLiteral(@"messagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-envelope fa-fw""></i>
                <!-- Counter - Messages -->
                <span class=""badge badge-danger badge-counter"">7</span>
            </a>
            <!-- Dropdown - Messages -->
            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""messagesDropdown"">
                <h6 class=""dropdown-header"">
                    Message Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/fn_BT9fwg_E/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 4075, "\"", 4081, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div class=""font-weight-bold"">
                        <div class=""text-truncate"">Hi there! I am wondering if you can help me with a problem I've been having.</div>
                        <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/AU4VPcFN4LE/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 4737, "\"", 4743, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">I have the photos that you ordered last month, how would you like them sent to you?</div>
                        <div class=""small text-gray-500"">Jae Chun · 1d</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/CS2uCrpNzJY/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 5365, "\"", 5371, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-warning""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">Last month's report looks great, I am very happy with the progress so far, keep up the good work!</div>
                        <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 6024, "\"", 6030, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">Am I a good boy? The reason I ask is because someone told me that people say this to all dogs, even if they aren't good...</div>
                        <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
            </div>
        </li>

        <div class=""topbar-divider d-none d-sm-block""></div>

        <!-- Nav Item - User Information -->
        <li class=""nav-item dropdown no-arrow"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">");
#nullable restore
#line 134 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
                                                                     Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                <img class=""img-profile rounded-circle"" src=""https://source.unsplash.com/QAB-WJcbgJk/60x60"">
            </a>
            <!-- Dropdown - User Information -->
            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""/Poslovodja/ViewMyProfile"">
                    <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                    Profile
                </a>
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                    Settings
                </a>
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                    Activity Log
                </a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""/Poslovodja/Logout"" data-toggle=""modal"" data-target=""#logo");
            WriteLiteral(@"utModal"">
                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                    Logout
                </a>
            </div>
        </li>

    </ul>

</nav>
<!-- End of Topbar

    <a class=""fa fa-arrow-left"" aria-hidden=""true"" href=""/Poslovodja/Index1""></a>
<br />

-->



<div class=""container"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Korisnički podaci</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
");
#nullable restore
#line 178 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\n\n        <tr>\n            <th>\n                Ime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 187 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
           Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Prezime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 195 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
           Write(Model.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Korisnicko ime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 203 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
           Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Password:\n            </th>\n            <td>\n                ");
#nullable restore
#line 211 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
           Write(Model.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Kontakt broj:\n            </th>\n            <td>\n                ");
#nullable restore
#line 219 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
           Write(Model.KontaktBroj);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Iskustvo:\n            </th>\n            <td>\n                ");
#nullable restore
#line 227 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
           Write(Model.iskustvo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n    </table> ");
#nullable restore
#line 230 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
             }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>There is nothing to show here...</h5>");
#nullable restore
#line 233 "C:\Users\krist\Desktop\Keebree\Views\Poslovodja\ViewMyProfile.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.Models.PoslovodjaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
