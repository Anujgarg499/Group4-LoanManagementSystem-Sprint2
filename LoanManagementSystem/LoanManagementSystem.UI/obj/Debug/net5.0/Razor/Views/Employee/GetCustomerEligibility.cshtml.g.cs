#pragma checksum "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\GetCustomerEligibility.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e5cf104e74fee170790a9845a93810054942591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetCustomerEligibility), @"mvc.1.0.view", @"/Views/Employee/GetCustomerEligibility.cshtml")]
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
#line 1 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\_ViewImports.cshtml"
using LoanManagementSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\_ViewImports.cshtml"
using LoanManagementSystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e5cf104e74fee170790a9845a93810054942591", @"/Views/Employee/GetCustomerEligibility.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27d9f9a4957a7006902d664896f7fae0ca4d8c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetCustomerEligibility : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\GetCustomerEligibility.cshtml"
  
    ViewData["Title"] = "GetCustomerEligibility";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1> Customer Eligibility Criteria is : ");
#nullable restore
#line 7 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\GetCustomerEligibility.cshtml"
                                       Write(ViewData["status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <br />\r\n    ");
#nullable restore
#line 9 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\GetCustomerEligibility.cshtml"
Write(Html.ActionLink("Back To Loan Processing", "LoanProcessing", new {  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591