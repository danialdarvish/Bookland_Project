#pragma checksum "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e3102b5ea3fd36d84c590b8f68b9c1b2355e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Banner.Pages_Shared_Components_Banner_BookDetailsBanner), @"mvc.1.0.view", @"/Pages/Shared/Components/Banner/BookDetailsBanner.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Banner
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
#line 1 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e3102b5ea3fd36d84c590b8f68b9c1b2355e94", @"/Pages/Shared/Components/Banner/BookDetailsBanner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Banner_BookDetailsBanner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_01_BooklandQuery.Contract.Banner.BannerQueryModel>
    {
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
            WriteLiteral("\r\n<div class=\"tg-featureditm\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12 col-sm-12 col-md-4 col-lg-4 hidden-sm hidden-xs\">\r\n            <figure>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "55e3102b5ea3fd36d84c590b8f68b9c1b2355e943367", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 225, "~/Pictures/", 225, 11, true);
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
AddHtmlAttributeValue("", 236, Model.Picture, 236, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
AddHtmlAttributeValue("", 257, Model.PictureAlt, 257, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
AddHtmlAttributeValue("", 283, Model.PictureTitle, 283, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</figure>\r\n        </div>\r\n        <div class=\"col-xs-12 col-sm-12 col-md-8 col-lg-8\">\r\n            <div class=\"tg-featureditmcontent\">\r\n                <div class=\"tg-themetagbox\"><span class=\"tg-themetag\">");
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                                                                 Write(Model.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                <div class=\"tg-booktitle\">\r\n                    <h3><a href=\"javascript:void(0);\">");
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                                                 Write(Model.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h3>\r\n                </div>\r\n                <span class=\"tg-bookwriter\">توسط: <a href=\"javascript:void(0);\">");
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                                                                           Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                <span class=\"tg-stars\"><span></span></span>\r\n                <div class=\"tg-priceandbtn\">\r\n                    <span class=\"tg-bookprice\">\r\n");
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                         if (Model.IsInStock)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                             if (Model.HasDiscount)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ins>");
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                                Write(Model.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</ins>\r\n                                <del>");
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</del>\r\n");
#nullable restore
#line 24 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ins>");
#nullable restore
#line 27 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</ins>\r\n");
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ins>به زودی</ins>\r\n");
#nullable restore
#line 33 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n");
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                     if (Model.IsInStock)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"tg-btn tg-btnstyletwo tg-active\" href=\"javascript:void(0);\">\r\n                            <i class=\"fa fa-shopping-basket\"></i>\r\n                            <em>افزودن به سبد خرید</em>\r\n                        </a>\r\n");
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Banner\BookDetailsBanner.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_01_BooklandQuery.Contract.Banner.BannerQueryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591