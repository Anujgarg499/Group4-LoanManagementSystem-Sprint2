#pragma checksum "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca63031359310d65c14bb5f67ad91f676f8b2602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ViewCustomer), @"mvc.1.0.view", @"/Views/Employee/ViewCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca63031359310d65c14bb5f67ad91f676f8b2602", @"/Views/Employee/ViewCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27d9f9a4957a7006902d664896f7fae0ca4d8c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ViewCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoanManagementSystem.UI.Models.Customer>>
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
#line 3 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
  
    ViewData["Title"] = "ViewCustomer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewCustomer</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca63031359310d65c14bb5f67ad91f676f8b26023976", async() => {
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
#line 17 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.PanNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.AadharNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.PanNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.AadharNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>            \r\n            <td>               \r\n                ");
#nullable restore
#line 83 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.CustomerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 84 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 87 "E:\CG\.net\Group4-LoanManagementSystem-Sprint2\LoanManagementSystem\LoanManagementSystem.UI\Views\Employee\ViewCustomer.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoanManagementSystem.UI.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
