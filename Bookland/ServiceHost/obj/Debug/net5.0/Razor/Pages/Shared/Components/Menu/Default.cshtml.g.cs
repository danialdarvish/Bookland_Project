#pragma checksum "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb129300c9a650aed1a6855984a87b18dbe471c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Menu.Pages_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Menu/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Menu
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb129300c9a650aed1a6855984a87b18dbe471c", @"/Pages/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_01_BooklandQuery.MenuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/images/img-01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""tg-navigationarea"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <nav id=""tg-nav"" class=""tg-nav"">
                    <div class=""navbar-header"">
                        <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#tg-navigation"" aria-expanded=""false"">
                            <span class=""sr-only"">Toggle navigation</span>
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                        </button>
                    </div>
                    <div id=""tg-navigation"" class=""collapse navbar-collapse tg-navigation"">
                        <ul>
                            <li class=""menu-item-has-children menu-item-has-mega-menu"">
                                <a href=""javascript:void(0);"">دسته‌بندی‌ها</a>
  ");
            WriteLiteral("                              <div class=\"mega-menu\">\r\n                                    <ul class=\"tg-themetabnav\" role=\"tablist\">\r\n");
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
                                         foreach (var parent in Model.BookCategories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li role=\"presentation\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1445, "\"", 1465, 2);
            WriteAttributeValue("", 1452, "#", 1452, 1, true);
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 1453, parent.Slug, 1453, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"artandphotography\" role=\"tab\" data-toggle=\"tab\">");
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
                                                                                                                                  Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 27 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                    <div class=\"tab-content tg-themetabcontent\">\r\n");
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
                                         foreach (var item in Model.BookCategories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div role=\"tabpanel\" class=\"tab-pane active\"");
            BeginWriteAttribute("id", " id=\"", 1983, "\"", 1998, 1);
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 1988, item.Slug, 1988, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <ul>\r\n                                                    <li>\r\n");
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
                                                         foreach (var children in item.Children)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <ul>\r\n                                                                <li><a href=\"products.html\">");
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
                                                                                       Write(children.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                                            </ul>\r\n");
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <a class=""tg-btnviewall"" href=""products.html"">مشاهده همه</a>
                                                    </li>
                                                </ul>
                                                <ul>
                                                    <li>
                                                        <figure>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5fb129300c9a650aed1a6855984a87b18dbe471c9544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</figure>
                                                        <div class=""tg-textbox"">
                                                            <h3>بیشتر از<span>12,0657,53</span>کالکشن کتاب</h3>
                                                            <div class=""tg-description"">
                                                                <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است</p>
                                                            </div>
                                                            <a class=""tg-btn"" href=""products.html"">مشاهده همه</a>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>
");
#nullable restore
#line 60 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           
                                    </div>
                                </div>
                            </li>
                            <li class=""menu-item-has-children current-menu-item"">
                                <a href=""javascript:void(0);"">خانه</a>
                                <ul class=""sub-menu"">
                                    <li class=""current-menu-item""><a href=""index-2.html"">خانه ورژن یک</a></li>
                                    <li><a href=""indexv2.html"">خانه ورژن دو</a></li>
                                    <li><a href=""indexv3.html"">خانه ورژن سه</a></li>
                                </ul>
                            </li>
                            <li class=""menu-item-has-children"">
                                <a href=""javascript:void(0);"">نویسندگان</a>
                                <ul class=""sub-menu"">
                                    <li><a href=""authors.html"">نویسندگان</a></li>
                            ");
            WriteLiteral(@"        <li><a href=""authordetail.html"">جزییات نویسندگان</a></li>
                                </ul>
                            </li>
                            <li><a href=""products.html"">پرفروش ترین</a></li>
                            <li><a href=""products.html"">تخفیف هفته</a></li>
                            <li class=""menu-item-has-children"">
                                <a href=""javascript:void(0);"">آخرین اخبار</a>
                                <ul class=""sub-menu"">
                                    <li><a href=""newslist.html"">لیست اخبار</a></li>
                                    <li><a href=""newsgrid.html"">گرید اخبار</a></li>
                                    <li><a href=""newsdetail.html"">جزییات خبر </a></li>
                                </ul>
                            </li>
                            <li><a href=""contactus.html"">ارتباط با ما</a></li>
                            <li class=""menu-item-has-children current-menu-item"">
                                <a");
            WriteLiteral(@" href=""javascript:void(0);""><i class=""icon-menu""></i></a>
                                <ul class=""sub-menu"">
                                    <li class=""menu-item-has-children"">
                                        <a href=""aboutus.html"">محصولات</a>
                                        <ul class=""sub-menu"">
                                            <li><a href=""products.html"">محصولات</a></li>
                                            <li><a href=""productdetail.html"">جزییات محصولات</a></li>
                                        </ul>
                                    </li>
                                    <li><a href=""aboutus.html"">درباره ما</a></li>
                                    <li><a href=""404error.html"">خطا 404</a></li>
                                    <li><a href=""comingsoon.html"">به زودی</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </nav>
          ");
            WriteLiteral("  </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_01_BooklandQuery.MenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
