#pragma checksum "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34fff1375afa279a0cbabd5b35ed7b98e22006da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_PaymentResult), @"mvc.1.0.razor-page", @"/Pages/PaymentResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34fff1375afa279a0cbabd5b35ed7b98e22006da", @"/Pages/PaymentResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_PaymentResult : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
  
    ViewData["Title"] = "نتیجه خرید";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""tg-innerbanner tg-haslayout tg-parallax tg-bginnerbanner"" data-z-index=""-100"" data-appear-top-offset=""600"" data-parallax=""scroll"" data-image-src=""/Theme/assets/images/parallax/bgparallax-07.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""tg-innerbannercontent"">
                    <h1>نتیجه خرید شما</h1>
                    <ol class=""tg-breadcrumb"">
                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34fff1375afa279a0cbabd5b35ed7b98e22006da4026", async() => {
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
                        <li><a>سبد خرید</a></li>
                        <li><a>تایید و پرداخت</a></li>
                        <li class=""tg-active""><a>نتیجه خرید شما</a></li>
                    </ol>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12"">
");
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
             if (Model.Result.IsSuccessful)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
                   Write(Model.Result.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
                     if (!string.IsNullOrWhiteSpace(Model.Result.IssueTrackingNo))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n                            شماره پیگیری:\r\n                            <strong>");
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
                               Write(Model.Result.IssueTrackingNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </p>\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
                   Write(Model.Result.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\PaymentResult.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.PaymentResultModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.PaymentResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.PaymentResultModel>)PageContext?.ViewData;
        public ServiceHost.Pages.PaymentResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
