#pragma checksum "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a79e1a22b84f25a1f84b342e80798357cb2aab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a79e1a22b84f25a1f84b342e80798357cb2aab5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Slide"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n<main id=\"tg-main\" class=\"tg-main tg-haslayout\">\r\n    <!--************************************\r\n    All Status Start\r\n    *************************************-->\r\n    ");
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    <!--************************************\r\n            All Status End\r\n    *************************************-->\r\n    <!--************************************\r\n    Best Selling Start\r\n    *************************************-->\r\n\r\n    ");
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("BestSelling"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <!--************************************\r\n            Best Selling End\r\n    *************************************-->\r\n    <!--************************************\r\n    Featured Item Start\r\n    *************************************-->\r\n\r\n    ");
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Banner", true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!--************************************
                Featured Item End
        *************************************-->
    <!--************************************
    New Release Start
    *************************************-->

    ");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("NewRelease"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!--************************************
            New Release End
    *************************************-->
    <!--************************************
            Collection Count Start
    *************************************-->
    ");
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("BookCount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!--************************************
                Collection Count End
        *************************************-->
    <!--************************************
    Picked By Author Start
    *************************************-->

    ");
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("BestBooks"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!--************************************
                    Picked By Author End
            *************************************-->
    <!--************************************
    Testimonials Start
    *************************************-->

    ");
#nullable restore
#line 64 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Quote"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!--************************************
                Testimonials End
        *************************************-->
    <!--************************************
            Authors Start
    *************************************-->
    ");
#nullable restore
#line 72 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("BestAuthors", "Default"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--************************************\r\n                Authors End\r\n        *************************************-->\r\n    <!--************************************\r\n    Call to Action Start\r\n    *************************************-->\r\n\r\n    ");
#nullable restore
#line 80 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("CallToAction"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <!--************************************\r\n            Call to Action End\r\n    *************************************-->\r\n    <!--************************************\r\n            Latest News Start\r\n    *************************************-->\r\n    ");
#nullable restore
#line 88 "C:\Users\ASUS\source\repos\Bookland_Project\Code\Bookland\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArticles", "Default"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--************************************\r\n                Latest News End\r\n        *************************************-->\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
