#pragma checksum "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ead3ec77f1e61dbe9523324d3b079be662150b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.BestSelling.Pages_Shared_Components_BestSelling_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/BestSelling/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.BestSelling
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ead3ec77f1e61dbe9523324d3b079be662150b", @"/Pages/Shared/Components/BestSelling/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_BestSelling_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_BooklandQuery.Contract.Book.BookQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./BookCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./BookDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AuthorDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""tg-sectionspace tg-haslayout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""tg-sectionhead"">
                    <h2><span>به انتخاب مردم</span>پرفروش ‌ترین‌ها</h2>
                    <a class=""tg-btn"" href=""javascript:void(0);"">مشاهده همه</a>
                </div>
            </div>
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div id=""tg-bestsellingbooksslider"" class=""tg-bestsellingbooksslider tg-bestsellingbooks owl-carousel"">
");
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                     foreach (var book in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
                            <div class=""tg-postbook"">
                                <figure class=""tg-featureimg"">
                                    <div class=""tg-bookimg"">
                                        <div class=""tg-frontcover"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36ead3ec77f1e61dbe9523324d3b079be662150b5470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1041, "~/Pictures/", 1041, 11, true);
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
AddHtmlAttributeValue("", 1052, book.Picture, 1052, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
AddHtmlAttributeValue("", 1072, book.PictureAlt, 1072, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
AddHtmlAttributeValue("", 1097, book.PictureTitle, 1097, 18, false);

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
            WriteLiteral("</div>\r\n                                        <div class=\"tg-backcover\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36ead3ec77f1e61dbe9523324d3b079be662150b8082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1201, "~/Pictures/", 1201, 11, true);
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
AddHtmlAttributeValue("", 1212, book.Picture, 1212, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
AddHtmlAttributeValue("", 1232, book.PictureAlt, 1232, 16, false);

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
            WriteLiteral(@"</div>
                                    </div>
                                    <a class=""tg-btnaddtowishlist"" href=""javascript:void(0);"">
                                        <i class=""icon-heart""></i>
                                        <span>افزودن به علاقه‌مندی‌ها</span>
                                    </a>
                                </figure>
                                <div class=""tg-postbookcontent"">
                                    <ul class=""tg-bookscategories"">
");
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                         foreach (var category in book.Categories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ead3ec77f1e61dbe9523324d3b079be662150b11041", async() => {
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                                                      Write(category.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                               WriteLiteral(category.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 33 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                    <div class=\"tg-booktitle\">\r\n                                        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ead3ec77f1e61dbe9523324d3b079be662150b14000", async() => {
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                                            Write(book.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                         WriteLiteral(book.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                                    </div>\r\n                                    <span class=\"tg-bookwriter\">توسط: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ead3ec77f1e61dbe9523324d3b079be662150b16620", async() => {
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                                                                              Write(book.AuthorName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                                                     WriteLiteral(book.AuthorSlug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                                    <span class=\"tg-stars\"><span></span></span>\r\n");
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                     if (book.IsEditorsChoice && book.HasDiscount)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"tg-themetagbox\"><span class=\"tg-themetag\">پیشنهاد خاص + ");
#nullable restore
#line 42 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                                                       Write(book.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" درصد تخفیف</span></div>\r\n");
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                    }
                                    else if (book.HasDiscount)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"tg-themetagbox\"><span class=\"tg-themetag fix-tag\">");
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                                                                 Write(book.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"tg-themetag\">درصد تخفیف</span></div>\r\n");
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                    }
                                    else if (book.IsEditorsChoice)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"tg-themetagbox\"><span class=\"tg-themetag\">پیشنهاد خاص</span></div>\r\n");
#nullable restore
#line 51 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"tg-bookprice\">\r\n");
#nullable restore
#line 53 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                         if (book.IsInStock)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                             if (book.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <ins>قیمت: ");
#nullable restore
#line 57 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                      Write(book.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</ins>\r\n                                                <del>قیمت: ");
#nullable restore
#line 58 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                      Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</del>\r\n");
#nullable restore
#line 59 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <ins>قیمت: ");
#nullable restore
#line 62 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                                      Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</ins>\r\n");
#nullable restore
#line 63 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                             
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <ins class=\"redText\">نا موجود</ins>\r\n");
#nullable restore
#line 68 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 73 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                             if (book.IsInStock)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"tg-btn tg-btnstyletwo\" href=\"javascript:void(0);\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4767, "\"", 4864, 15);
            WriteAttributeValue("", 4777, "addToCart(\'", 4777, 11, true);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
WriteAttributeValue("", 4788, book.Id, 4788, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4796, "\',", 4796, 2, true);
            WriteAttributeValue(" ", 4798, "\'", 4799, 2, true);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
WriteAttributeValue("", 4800, book.Name, 4800, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4810, "\',", 4810, 2, true);
            WriteAttributeValue(" ", 4812, "\'", 4813, 2, true);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
WriteAttributeValue("", 4814, book.DoublePrice, 4814, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4831, "\',", 4831, 2, true);
            WriteAttributeValue(" ", 4833, "\'", 4834, 2, true);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
WriteAttributeValue("", 4835, book.Picture, 4835, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4848, "\',", 4848, 2, true);
            WriteAttributeValue(" ", 4850, "\'", 4851, 2, true);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
WriteAttributeValue("", 4852, book.Slug, 4852, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4862, "\')", 4862, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"float: right\">\r\n                                    <i class=\"fa fa-shopping-basket\"></i>\r\n                                    <em>افزودن به سبد خرید</em>\r\n                                </a>\r\n");
#nullable restore
#line 79 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 81 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Shared\Components\BestSelling\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_BooklandQuery.Contract.Book.BookQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
