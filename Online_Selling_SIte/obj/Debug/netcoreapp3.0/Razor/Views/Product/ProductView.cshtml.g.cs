#pragma checksum "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe2c26b7833bae464317fdb42b42d4d07a83611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductView), @"mvc.1.0.view", @"/Views/Product/ProductView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe2c26b7833bae464317fdb42b42d4d07a83611", @"/Views/Product/ProductView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861796b981632b03ed5209278ad23ad63fd71b13", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Online_Selling_SIte.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:101px; vertical-align:bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
  
    ViewData["Title"] = "ProductView";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title""><b>Products</b></h3>
                </div><!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example2"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 21 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 24 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 27 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.Qnt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 30 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 33 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.Saleprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 36 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 39 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.UploadDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 42 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 45 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayNameFor(model => model.Discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 50 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 54 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 57 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 60 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Qnt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 63 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 66 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Saleprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fe2c26b7833bae464317fdb42b42d4d07a8361111453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3155, "~/ProductImages/", 3155, 16, true);
#nullable restore
#line 69 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
AddHtmlAttributeValue("", 3171, item.Image, 3171, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 73 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.UploadDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <span>");
#nullable restore
#line 76 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                                     Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 79 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 82 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Product\ProductView.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Online_Selling_SIte.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
