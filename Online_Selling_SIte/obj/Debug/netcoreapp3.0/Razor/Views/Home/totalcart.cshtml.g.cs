#pragma checksum "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8bd8fc0d2c528364f5edf52fb96a5fc867134a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_totalcart), @"mvc.1.0.view", @"/Views/Home/totalcart.cshtml")]
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
#line 1 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\_ViewImports.cshtml"
using Online_Selling_SIte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\_ViewImports.cshtml"
using Online_Selling_SIte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8bd8fc0d2c528364f5edf52fb96a5fc867134a0", @"/Views/Home/totalcart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861796b981632b03ed5209278ad23ad63fd71b13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_totalcart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Online_Selling_SIte.Models.CommanCart>>
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
#line 3 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
  
    ViewData["Title"] = "totalcart";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>totalcart</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8bd8fc0d2c528364f5edf52fb96a5fc867134a03970", async() => {
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
#line 17 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.productid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.Qnt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.saleprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.orderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 71 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.productid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qnt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.saleprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.orderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 122 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 125 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 126 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 127 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 130 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Home\totalcart.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Online_Selling_SIte.Models.CommanCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
