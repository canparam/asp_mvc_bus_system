#pragma checksum "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41d4ed7801c6cf40948a1d704fb8186e2609cd2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partner_Account_Dashboard), @"mvc.1.0.view", @"/Views/Partner/Account/Dashboard.cshtml")]
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
#line 1 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
using BusSystem.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
using BusSystem.Data.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d4ed7801c6cf40948a1d704fb8186e2609cd2e", @"/Views/Partner/Account/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd8083edded6776e3790aff0cf7d560b8ba655e", @"/Views/_ViewImports.cshtml")]
    public class Views_Partner_Account_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusSytem.Services.Implements.PageList<BusSystem.Model.Transacion.TranserHisViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "partner.dashboard.user", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 10 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
  
    var test = await walletSerive.UserAmount();
    var trans = await TransactionHisService.GetTotalTransaction();
    var oder = await orderSerive.TotalOrder();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Partner/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""inner-banner bg_img"" style=""background: url(https://script.viserlab.com/viserbus/assets/images/frontend/breadcrumb/61f14e10b48871643204112.jpg) center"">
    <div class=""container"">
        <div class=""inner-banner-content"">
            <h2 class=""title"">Dashboard</h2>
        </div>
    </div>
</section>
<section class=""dashboard-section padding-top padding-bottom"">
    <div class=""container"">
        <div class=""dashboard-wrapper"">
            <div class=""row pb-60 gy-4 justify-content-center"">
                <div class=""col-lg-4 col-md-6 col-sm-10"">
                    <div class=""dashboard-widget"">
                        <div class=""dashboard-widget__content"">
                            <p>Total Booked Ticket</p>
                            <h3 class=""title"">");
#nullable restore
#line 36 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                         Write(oder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                        <div class=""dashboard-widget__icon"">
                            <i class=""las la-ticket-alt""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-10"">
                    <div class=""dashboard-widget"">
                        <div class=""dashboard-widget__content"">
                            <p>Total Transaction</p>
                            <h3 class=""title"">");
#nullable restore
#line 47 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                         Write(trans);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                        <div class=""dashboard-widget__icon"">
                            <i class=""las la-ticket-alt""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-10"">
                    <div class=""dashboard-widget"">
                        <div class=""dashboard-widget__content"">
                            <p>Amount</p>
                            <h3 class=""title"">");
#nullable restore
#line 58 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                         Write(test);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"$</h3>
                        </div>
                        <div class=""dashboard-widget__icon"">
                            <i class=""las la-ticket-alt""></i>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""booking-table-wrapper"">
                <table class=""booking-table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Credit</th>
                            <th>Status</th>
                            <th>Type</th>
                            <th>Message	</th>
                            <th>Created At</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 81 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">#</th>\r\n                                <td>");
#nullable restore
#line 85 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                               Write(item.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 87 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                      
                                        var status = item.Status == (int)TransactionStatus.PLUS ? "Plus" : "Sub";
                                        var classStatus = item.Status == (int)TransactionStatus.PLUS ? "badge bg--success" : "badge bg--danger";
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span");
            BeginWriteAttribute("class", " class=\"", 4138, "\"", 4158, 1);
#nullable restore
#line 91 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
WriteAttributeValue("", 4146, classStatus, 4146, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                                          Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 94 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                      
                                        var type = "";
                                        switch (item.Type)
                                        {
                                            case (int)TransactionType.ADMIN_SEND:
                                                type = "From Admin";
                                                break;
                                            case (int)TransactionType.BUY:
                                                type = "Buy";
                                                break;
                                            case (int)TransactionType.REFUND:
                                                type = "Refund";
                                                break;
                                            case (int)TransactionType.ADMIN_ROLLBACK:
                                                type = "Admin RollBack";
                                                break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span>");
#nullable restore
#line 113 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                     Write(type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 115 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                               Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 116 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                               Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 118 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 121 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                  
                    var preDisabled = !Model.PreviousPage ? "disabled" : "";
                    var nextDisbled = !Model.NextPage ? "disabled" : "";
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"d-flex justify-content-end mt-2\">\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 5961, "\"", 5991, 2);
            WriteAttributeValue("", 5969, "page-item", 5969, 9, true);
#nullable restore
#line 126 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
WriteAttributeValue(" ", 5978, preDisabled, 5979, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d4ed7801c6cf40948a1d704fb8186e2609cd2e14393", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                                                                     WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 6193, "\"", 6223, 2);
            WriteAttributeValue("", 6201, "page-item", 6201, 9, true);
#nullable restore
#line 129 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
WriteAttributeValue(" ", 6210, nextDisbled, 6211, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d4ed7801c6cf40948a1d704fb8186e2609cd2e17307", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\Dashboard.cshtml"
                                                                                     WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<BusSystem.Entity.IdentityAccess.User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<BusSystem.Entity.IdentityAccess.User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BusSystem.Services.Interfaces.IOrderService orderSerive { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BusSystem.Services.Interfaces.ITransactionHisService TransactionHisService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BusSystem.Services.Interfaces.IWalletService walletSerive { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusSytem.Services.Implements.PageList<BusSystem.Model.Transacion.TranserHisViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
