#pragma checksum "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05f354f08cdc5975368e43e6a267922e209c4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_MyCart), @"mvc.1.0.view", @"/Views/Cart/MyCart.cshtml")]
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
#nullable restore
#line 3 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05f354f08cdc5975368e43e6a267922e209c4ad", @"/Views/Cart/MyCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861796b981632b03ed5209278ad23ad63fd71b13", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_MyCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Online_Selling_SIte.Models.CommanCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                                     
    if (Context.Session.GetString("UserName") == null)
    {
        Context.Response.Redirect("/UserLogin/Index");
    }
    ViewData["Title"] = "MyCart";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url('/Content/UserContent/images/bg_6.jpg');"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-0 bread"">My Cart</h1>
            </div>
        </div>
    </div>
</div>
<section class=""ftco-section ftco-cart"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 ftco-animate"">
                <div class=""cart-list"">
                    <table class=""table"">
                        <thead class=""thead-primary"">
                            <tr class=""text-center"">
                                <th>&nbsp;</th>
                                <th>&nbsp;</th>
                                <th>Product</th>
                                <th>Price</th>
                                <th>Quantity</th>
                                <th>To");
            WriteLiteral("tal</th>\r\n                            </tr>\r\n                        </thead>\r\n\r\n");
#nullable restore
#line 37 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>\r\n                                <tr class=\"text-center\">\r\n                                    <td class=\"product-remove\"><a");
            BeginWriteAttribute("href", " href=\"", 1663, "\"", 1729, 2);
            WriteAttributeValue("", 1670, "/Cart/RemoveCart/", 1670, 17, true);
#nullable restore
#line 41 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
WriteAttributeValue("", 1687, Html.DisplayFor(modelItem => item.CartId), 1687, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Remove Cart\"><span class=\"ion-ios-close\"></span></a></td>\r\n\r\n                                    <td class=\"image-prod\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a05f354f08cdc5975368e43e6a267922e209c4ad6951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1868, "~/ProductImages/", 1868, 16, true);
#nullable restore
#line 43 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
AddHtmlAttributeValue("", 1884, item.Image, 1884, 11, false);

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
            WriteLiteral("</td>\r\n\r\n                                    <td class=\"product-name\">\r\n                                        <h3> ");
#nullable restore
#line 46 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <p>");
#nullable restore
#line 47 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td class=\"price\"><p>");
#nullable restore
#line 49 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.saleprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    <td class=\"quantity\">\r\n                                        <div class=\"input-group mb-3\">\r\n                                            <input disabled=\"disabled\" name=\"quantity\" class=\" form-control \"");
            BeginWriteAttribute("value", " value=\"", 2567, "\"", 2614, 1);
#nullable restore
#line 52 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
WriteAttributeValue("", 2575, Html.DisplayFor(modelItem => item.Qnt), 2575, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </div>\r\n                                    </td>\r\n\r\n                                    <td class=\"total\"><p>");
#nullable restore
#line 56 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                </tr><!-- END TR-->\r\n                            </tbody>\r\n");
#nullable restore
#line 59 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05f354f08cdc5975368e43e6a267922e209c4ad11571", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
             if (ViewBag.GrandTotal != 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""row justify-content-center"">
                    <div class=""col col-lg-5 col-md-6 mt-5 cart-wrap ftco-animate"">

                        <div class=""cart-total mb-3"">
                            <h3>Cart Totals</h3>
                            <p class=""d-flex"">
                                <span>Subtotal</span>
                                <span>");
#nullable restore
#line 76 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                                 Write(ViewBag.GrandTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </p>\r\n");
                WriteLiteral("                            <hr>\r\n                            <p class=\"d-flex total-price\">\r\n                                <span>Total</span>\r\n                                <span>");
#nullable restore
#line 89 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                                 Write(ViewBag.GrandTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                            </p>
                        </div>

                        <p class=""text-center""><a href=""/Order/ProceedOrder"" class=""btn btn-primary py-3 px-4"">Proceed to Checkout</a></p>



                    </div>
                </div>
");
#nullable restore
#line 99 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <center> <h3 class=\"mb-0 bread\">Your Cart is Empty!!</h3></center>\r\n");
#nullable restore
#line 103 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n    }\r\n");
#nullable restore
#line 110 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $.alert({\r\n                title: \'Alert!\',\r\n                content: ");
#nullable restore
#line 116 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"
                    Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            });\r\n        })\r\n        </script>\r\n");
#nullable restore
#line 120 "E:\GitHubDemo\Online_SellingSiteWith_Payment\OnlineSellSystemwithPaymentIntegration\Online_Selling_SIte\Views\Cart\MyCart.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n\r\n");
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
