#pragma checksum "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\Shared\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f2c0f83537e5e5705dfd750ae5ea84dd934260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Shared_Header), @"mvc.1.0.view", @"/Views/Admin/Shared/Header.cshtml")]
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
#line 1 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\_ViewImports.cshtml"
using BusSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\_ViewImports.cshtml"
using BusSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\Shared\Header.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f2c0f83537e5e5705dfd750ae5ea84dd934260", @"/Views/Admin/Shared/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd8083edded6776e3790aff0cf7d560b8ba655e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Shared_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "admin.logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\Shared\Header.cshtml"
   
    var user = await UserManager.GetUserAsync(User); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""header header-sticky mb-4"">
    <div class=""container-fluid"">
        <button class=""header-toggler px-md-0 me-md-3"" type=""button"" onclick=""coreui.Sidebar.getInstance(document.querySelector('#sidebar')).toggle()"">
            <svg class=""icon icon-lg"">
                <use xlink:href=""/admin/vendors/coreui/icons/svg/free.svg#cil-menu""></use>
            </svg>
        </button><a class=""header-brand d-md-none"" href=""#"">
            <svg width=""118"" height=""46"" alt=""CoreUI Logo"">
                <use xlink:href=""assets/brand/coreui.svg#full""></use>
            </svg>
        </a>
        <ul class=""header-nav d-none d-md-flex"">
            <li class=""nav-item""><a class=""nav-link"" href=""#"">Dashboard</a></li>
            <li class=""nav-item""><a class=""nav-link"" href=""#"">Users</a></li>
            <li class=""nav-item""><a class=""nav-link"" href=""#"">Settings</a></li>
        </ul>
        <ul class=""header-nav ms-auto"">
            
        </ul>
        <ul class=""header-nav ms-3");
            WriteLiteral(@""">
            <li class=""nav-item dropdown"">
                <a class=""nav-link py-0"" data-coreui-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                    <div class=""avatar avatar-md""><img class=""avatar-img"" src=""/admin/assets/img/avatars/8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1569, "\"", 1586, 1);
#nullable restore
#line 30 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\Shared\Header.cshtml"
WriteAttributeValue("", 1575, user.Email, 1575, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></div>
                </a>
                <div class=""dropdown-menu dropdown-menu-end pt-0"">
                    <div class=""dropdown-header bg-light py-2"">
                        <div class=""fw-semibold"">Settings</div>
                    </div><a class=""dropdown-item"" href=""#"">
                        <svg class=""icon me-2"">
                            <use xlink:href=""/admin/vendors/coreui/icons/svg/free.svg#cil-user""></use>
                        </svg> Profile
                    </a>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f2c0f83537e5e5705dfd750ae5ea84dd9342606480", async() => {
                WriteLiteral("\r\n                        <svg class=\"icon me-2\">\r\n                            <use xlink:href=\"/admin/vendors/coreui/icons/svg/free.svg#cil-account-logout\"></use>\r\n                        </svg> Logout\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </li>
        </ul>
    </div>
    <div class=""header-divider""></div>
    <div class=""container-fluid"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb my-0 ms-2"">
                <li class=""breadcrumb-item"">
                    <!-- if breadcrumb is single--><span>Home</span>
                </li>
                <li class=""breadcrumb-item active""><span>Dashboard</span></li>
            </ol>
        </nav>
    </div>
</header>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<BusSystem.Entity.IdentityAccess.User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<BusSystem.Entity.IdentityAccess.User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591