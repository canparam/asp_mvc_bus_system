#pragma checksum "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95b9fcb867cfd915d397a0758776db97d4d0238"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partner_Account_ModalInfo), @"mvc.1.0.view", @"/Views/Partner/Account/ModalInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95b9fcb867cfd915d397a0758776db97d4d0238", @"/Views/Partner/Account/ModalInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd8083edded6776e3790aff0cf7d560b8ba655e", @"/Views/_ViewImports.cshtml")]
    public class Views_Partner_Account_ModalInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusSystem.Model.Order.OrderDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .bo {\r\n        border-bottom: 1px dashed #ebebeb;\r\n        padding: 5px 0;\r\n    }\r\n</style>\r\n\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>Order Date</strong>  <span>");
#nullable restore
#line 10 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                  Write(Model.OrderCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p class=\"d-flex flex-wrap justify-content-between bo\">\r\n    <strong>Status</strong>  <span>\r\n");
#nullable restore
#line 14 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
          
            var oder = "";
            var clas = "";
            switch (Model.OrderStatus)
            {
                case 0:
                    oder = "Paid";
                    clas = "badge badge--success";
                    break;
                case 1:
                    oder = "Refund";
                    clas = "badge badge--danger";
                    break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span");
            BeginWriteAttribute("class", " class=\"", 836, "\"", 849, 1);
#nullable restore
#line 29 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
WriteAttributeValue("", 844, clas, 844, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                       Write(oder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </span>\r\n</p>\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>From</strong>  <span>");
#nullable restore
#line 33 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                            Write(Model.From);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>To</strong>  <span>");
#nullable restore
#line 37 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                          Write(Model.To);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>StartTime</strong>  <span>");
#nullable restore
#line 40 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                 Write(Model.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>Bus Name</strong>  <span>");
#nullable restore
#line 43 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                Write(Model.BusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>Price: </strong>  <span>");
#nullable restore
#line 46 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                               Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</span>\r\n</p>\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>Discount: </strong>  <span>");
#nullable restore
#line 49 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                  Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n</p>\r\n<p class=\"d-flex flex-wrap justify-content-between pt-0 bo\">\r\n    <strong>Amount: </strong>  <span>");
#nullable restore
#line 52 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"$</span>
</p>
<div class=""mt-2"">
    <div class=""d-flex justify-content-between"">
        <h5>Info Ticket:</h5>
        <i class=""las la-print text--info"" onClick=""printdiv('tiket');"" style=""font-size: 20px; cursor: pointer""></i>
    </div>
    <p class="" bo""></p>
    <div id=""tiket"">
        <p class=""d-flex flex-wrap justify-content-between pt-0 bo"">
            <strong>CODE: </strong>  <span>");
#nullable restore
#line 62 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                      Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </p>\r\n        <p class=\"d-flex flex-wrap justify-content-between pt-2 bo\">\r\n            <strong>CUSTOM NAME: </strong>  <span>");
#nullable restore
#line 65 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                             Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </p>\r\n        <p class=\"d-flex flex-wrap justify-content-between pt-2 bo\">\r\n            <strong>CUSTOM PHONE: </strong>  <span>");
#nullable restore
#line 68 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                                              Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </p>\r\n        <p class=\"d-flex flex-wrap justify-content-between pt-2 bo\">\r\n            <strong>STATUS: </strong>\r\n");
#nullable restore
#line 72 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
              
                var ticket = "";
                var clasTik = "";
                switch (Model.TicketStatus)
                {
                    case 0:
                        ticket = "Active";
                        clasTik = "badge badge--success";
                        break;
                    case 1:
                        ticket = "Used";
                        clasTik = "badge badge--warning";
                        break;
                    case 2:
                        ticket = "Cancel";
                        clasTik = "badge badge--danger";
                        break;
                }
                var time = DateTime.Now;
                if (Model.StartTime < time)
                {
                    ticket = "Expired";
                    clasTik = "badge badge--warning";
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span");
            BeginWriteAttribute("class", " class=\"", 3528, "\"", 3544, 1);
#nullable restore
#line 97 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
WriteAttributeValue("", 3536, clasTik, 3536, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "C:\Users\Can\source\repos\BusSystem\BusSystem\Views\Partner\Account\ModalInfo.cshtml"
                              Write(ticket);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
        </p>
    </div>
</div>
<script>
    function printdiv(printpage) {
        var headstr = ""<html><head><title></title></head><body>"";
        var footstr = ""</body>"";
        var newstr = document.all.item(printpage).innerHTML;
        var oldstr = document.body.innerHTML;
        document.body.innerHTML = headstr + newstr + footstr;
        window.print();
        document.body.innerHTML = oldstr;
        return false;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusSystem.Model.Order.OrderDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
