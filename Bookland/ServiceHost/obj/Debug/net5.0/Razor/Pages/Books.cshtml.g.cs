#pragma checksum "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd6e78b912468fc165ae53f2014025225cf7a44c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Books), @"mvc.1.0.razor-page", @"/Pages/Books.cshtml")]
namespace ServiceHost.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd6e78b912468fc165ae53f2014025225cf7a44c", @"/Pages/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Books : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tg-formtheme tg-formsortshoitems"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/BookCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/BookDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tg-formtheme tg-formsearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
  
    ViewData["Title"] = "نتیجه جستجو";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""tg-innerbanner tg-haslayout tg-parallax tg-bginnerbanner"" data-z-index=""-100"" data-appear-top-offset=""600"" data-parallax=""scroll"" data-image-src=""/Theme/assets/images/parallax/bgparallax-07.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""tg-innerbannercontent"">
                    <h1>محصولات</h1>
                    <ol class=""tg-breadcrumb"">
                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c5892", async() => {
                WriteLiteral("خانه");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""tg-active"">جستجو</li>
                    </ol>
                </div>
            </div>
        </div>
    </div>
</div>

<main id=""tg-main"" class=""tg-main tg-haslayout"">
    <div class=""tg-sectionspace tg-haslayout"">
        <div class=""container"">
            <div class=""row"">
                <div id=""tg-twocolumns"" class=""tg-twocolumns"">
                    <div class=""col-xs-12 col-sm-8 col-md-8 col-lg-9 pull-right"">
                        <div id=""tg-content"" class=""tg-content"">
                            <div class=""tg-products"">
                                <div class=""tg-sectionhead"">
                                    <h2><span>به انتخاب مردم</span>پرفروش‌ ترین‌ها</h2>
                                </div>
                                <div class=""tg-featurebook alert"" role=""alert"">
                                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                  ");
            WriteLiteral("      <span aria-hidden=\"true\">&times;</span>\r\n                                    </button>\r\n                                    ");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                               Write(await Component.InvokeAsync("Banner", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""tg-productgrid"">
                                    <div class=""tg-refinesearch"">
                                        <span>مشاهده 1 از 8 از کل 20</span>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c8848", async() => {
                WriteLiteral(@"
                                            <fieldset>
                                                <div class=""form-group"">
                                                    <label>چینش:</label>
                                                    <span class=""tg-select"">
                                                        <select>
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c9517", async() => {
                    WriteLiteral("نام");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c10588", async() => {
                    WriteLiteral("نام");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c11660", async() => {
                    WriteLiteral("نام");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                        </select>
                                                    </span>
                                                </div>
                                                <div class=""form-group"">
                                                    <label>نمایش:</label>
                                                    <span class=""tg-select"">
                                                        <select>
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c13212", async() => {
                    WriteLiteral("8");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c14282", async() => {
                    WriteLiteral("16");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c15353", async() => {
                    WriteLiteral("20");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                        </select>
                                                    </span>
                                                </div>
                                            </fieldset>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 69 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                     foreach (var book in Model.Books)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-xs-6 col-sm-6 col-md-4 col-lg-3"">
                                            <div class=""tg-postbook"">
                                                <figure class=""tg-featureimg"">
                                                    <div class=""tg-bookimg"">
                                                        <div class=""tg-frontcover"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd6e78b912468fc165ae53f2014025225cf7a44c18472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4330, "~/Pictures/", 4330, 11, true);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
AddHtmlAttributeValue("", 4341, book.Picture, 4341, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
AddHtmlAttributeValue("", 4361, book.PictureAlt, 4361, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
AddHtmlAttributeValue("", 4386, book.PictureTitle, 4386, 18, false);

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
            WriteLiteral("</div>\r\n                                                        <div class=\"tg-backcover\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd6e78b912468fc165ae53f2014025225cf7a44c21005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4506, "~/Pictures/", 4506, 11, true);
#nullable restore
#line 76 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
AddHtmlAttributeValue("", 4517, book.Picture, 4517, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
AddHtmlAttributeValue("", 4537, book.PictureAlt, 4537, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
AddHtmlAttributeValue("", 4562, book.PictureTitle, 4562, 18, false);

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
#line 85 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                         foreach (var category in book.Categories)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c24521", async() => {
#nullable restore
#line 87 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                                                                                     Write(category.Name);

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
#line 87 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
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
#line 88 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </ul>\r\n");
            WriteLiteral("                                                    <div class=\"tg-booktitle\">\r\n                                                        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c27509", async() => {
#nullable restore
#line 92 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                                                                           Write(book.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
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
            WriteLiteral("</h3>\r\n                                                    </div>\r\n                                                    <span class=\"tg-bookwriter\">توسط: <a href=\"javascript:void(0);\">");
#nullable restore
#line 94 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                                                                               Write(book.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                                                    <span class=\"tg-stars\"><span></span></span>\r\n                                                    <span class=\"tg-bookprice\">\r\n");
#nullable restore
#line 97 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                         if (book.IsInStock)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                             if (book.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <ins>");
#nullable restore
#line 101 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                                Write(book.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</ins>\r\n                                                                <del>");
#nullable restore
#line 102 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                                Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</del>\r\n");
#nullable restore
#line 103 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <ins class=\"blackText\">");
#nullable restore
#line 106 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                                                  Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</ins>\r\n");
#nullable restore
#line 107 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"

                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                             
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <ins class=\"redText\">نا موجود</ins>\r\n");
#nullable restore
#line 113 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </span>
                                                    <a class=""tg-btn tg-btnstyletwo"" href=""javascript:void(0);"">
                                                        <i class=""fa fa-shopping-basket""></i>
                                                        <em>افزودن به سبدخرید</em>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 122 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xs-12 col-sm-4 col-md-4 col-lg-3 pull-left"">
                        <aside id=""tg-sidebar"" class=""tg-sidebar"">
                            <div class=""tg-widget tg-widgetsearch"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6e78b912468fc165ae53f2014025225cf7a44c35226", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <button type=""submit""><i class=""icon-magnifier""></i></button>
                                        <input type=""search"" name=""search"" class=""form-group"" placeholder=""جستجو با نام، نویسنده و ... "">
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                            ");
#nullable restore
#line 138 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                       Write(await Component.InvokeAsync("BookCategoriesSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            ");
#nullable restore
#line 140 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                       Write(await Component.InvokeAsync("LatestArticles", "SideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            ");
#nullable restore
#line 142 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Books.cshtml"
                       Write(await Component.InvokeAsync("BestAuthors", "SideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </aside>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.BooksModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.BooksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.BooksModel>)PageContext?.ViewData;
        public ServiceHost.Pages.BooksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
