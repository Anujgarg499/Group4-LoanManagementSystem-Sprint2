#pragma checksum "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1718e0784df1774cf452172a1fe603439fec3c6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetStatus), @"mvc.1.0.view", @"/Views/Customer/GetStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1718e0784df1774cf452172a1fe603439fec3c6b", @"/Views/Customer/GetStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27d9f9a4957a7006902d664896f7fae0ca4d8c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoanManagementSystem.UI.Models.LoanDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
  
    ViewData["Title"] = "GetStatus";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetStatus</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1718e0784df1774cf452172a1fe603439fec3c6b3955", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanAccNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.EmpId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanApprovedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.LoanStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.DispersalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.InterestRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.Tenure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.EmiStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.EmiEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.EmiAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.CreditLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.LastUpdatedCreditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAssetId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 68 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanAccNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmpId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanApprovedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.DispersalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.InterestRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tenure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmiStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmiEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmiAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreditLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastUpdatedCreditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAssetId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 120 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 121 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 124 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Customer\GetStatus.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoanManagementSystem.UI.Models.LoanDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
