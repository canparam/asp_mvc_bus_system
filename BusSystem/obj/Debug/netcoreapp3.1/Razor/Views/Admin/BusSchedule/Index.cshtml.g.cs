#pragma checksum "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d10dc79a06f96e40469e1e3bf0a31ebb7090b1d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BusSchedule_Index), @"mvc.1.0.view", @"/Views/Admin/BusSchedule/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10dc79a06f96e40469e1e3bf0a31ebb7090b1d4", @"/Views/Admin/BusSchedule/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd8083edded6776e3790aff0cf7d560b8ba655e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BusSchedule_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusSytem.Services.Implements.PageList<BusSystem.Model.BusSchedule.BusScheduleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "admin.busschedule.delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "admin.partner.list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/pages/BusSchedule.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/Shared/_Layout.cshtml";
    ViewData["message"] = TempData["message"] ?? "";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .select2-container {
        width: 100% !important;
    }

    html {
        overflow-x: hidden;
    }
</style>
<div class=""body flex-grow-1 px-3"">
    <div class=""container-lg"">
        <div class=""card mb-4"">
            <div class=""card-header""><strong>Search</strong></div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d10dc79a06f96e40469e1e3bf0a31ebb7090b1d46612", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <div class=""form-group"">
                                <label for=""nf-email"">BusName</label>
                                <input class=""form-control"" type=""text"" name=""BusName""");
                BeginWriteAttribute("value", " value=\"", 925, "\"", 949, 1);
#nullable restore
#line 28 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
WriteAttributeValue("", 933, ViewBag.BusName, 933, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""BusName"">
                            </div>
                        </div>
                        <div class=""col-lg-3"">
                            <div class=""form-group"">
                                <label for=""nf-email"">Status</label>
                                ");
#nullable restore
#line 34 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                           Write(Html.DropDownList("status", (IEnumerable<SelectListItem>)ViewBag.listStatus, "-- Select --", new { @class = "form-select form-select-sm" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            </div>
                        </div>

                    </div>
                    <div class=""row mt-2"">
                        <div class=""col-lg-12"">
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary pull-right"">Search</button>
                            </div>
                        </div>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""card mb-4"">
            <div class=""card-header""><strong>List</strong></div>
            <div class=""card-body"">
                <div class=""table-responsive"">

                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">BusName</th>
                                <th scope=""col"">NumberPassengers</th>
                                <th scope=""col"">Address</th>
                                <th scope=""col"" style=""min-width: 100px"">Price Ticket</th>
                                <th scope=""col"">Start Time</th>
                                <th scope=""col"" style=""min-width: 100px"">Total Ticket</th>
                                <th scope=""col"">Status</th>
                                <th scope=""col"">Created Date</th>
                                <th scope=""col"" cl");
            WriteLiteral("ass=\"text-center\" style=\"min-width: 150px\">Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th>#</th>\r\n                                    <td>");
#nullable restore
#line 76 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                   Write(item.BusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 77 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                   Write(item.NumberPassengers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <p>From: ");
#nullable restore
#line 79 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                            Write(item.From);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>To: ");
#nullable restore
#line 80 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                          Write(item.To);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 82 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                   Write(item.PriceTicket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 83 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                   Write(item.StartTime?.ToLocalTime());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 84 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                                       Write(item.TotalTicket);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 84 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                                                           Write(item.NumberPassengers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n");
#nullable restore
#line 86 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                          
                                            var status = item.Status == 0 ? "Active" : "InActive";
                                            var className = item.Status == 0 ? "badge bg-success" : "badge bg-danger";
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span");
            BeginWriteAttribute("class", " class=\"", 4224, "\"", 4242, 1);
#nullable restore
#line 90 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
WriteAttributeValue("", 4232, className, 4232, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                                            Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 92 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                   Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"d-flex\">\r\n                                            <button class=\"btn btn-warning btn-sm mx-2 text-white\" data-click=\"edit\" data-id=\"");
#nullable restore
#line 95 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</button>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d10dc79a06f96e40469e1e3bf0a31ebb7090b1d416372", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 4803, "\"", 4819, 1);
#nullable restore
#line 97 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
WriteAttributeValue("", 4811, item.Id, 4811, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                <button class=\"btn btn-danger btn-sm mx-2 text-white\">Delete</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 103 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 107 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                      
                        var preDisabled = !Model.PreviousPage ? "disabled" : "";
                        var nextDisbled = !Model.NextPage ? "disabled" : "";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination justify-content-end\">\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5607, "\"", 5637, 2);
            WriteAttributeValue("", 5615, "page-item", 5615, 9, true);
#nullable restore
#line 114 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
WriteAttributeValue(" ", 5624, preDisabled, 5625, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d10dc79a06f96e40469e1e3bf0a31ebb7090b1d420132", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
                                                                                     WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5847, "\"", 5877, 2);
            WriteAttributeValue("", 5855, "page-item", 5855, 9, true);
#nullable restore
#line 117 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
WriteAttributeValue(" ", 5864, nextDisbled, 5865, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d10dc79a06f96e40469e1e3bf0a31ebb7090b1d423054", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Admin\BusSchedule\Index.cshtml"
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
            WriteLiteral(@"
                        </li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""modal_busche"" data-coreui-backdrop=""static"" data-coreui-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""staticBackdropLabel"">Edit </h5>
                <button type=""button"" class=""btn-close"" data-coreui-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-coreui-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" id=""btn_update"" data-click=""submitUpdate"">Save</button>
            </di");
            WriteLiteral("v>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d10dc79a06f96e40469e1e3bf0a31ebb7090b1d426602", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusSytem.Services.Implements.PageList<BusSystem.Model.BusSchedule.BusScheduleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
