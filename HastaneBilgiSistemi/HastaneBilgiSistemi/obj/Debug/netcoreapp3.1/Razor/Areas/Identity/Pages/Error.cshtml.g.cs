#pragma checksum "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fe380d17194282ba7b4d9f1a0fe408a46a61d9019109dfa10486befb4920d548"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Error), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Error.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\_ViewImports.cshtml"
using HastaneBilgiSistemi.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\_ViewImports.cshtml"
using HastaneBilgiSistemi.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\_ViewImports.cshtml"
using HastaneBilgiSistemi.Data.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fe380d17194282ba7b4d9f1a0fe408a46a61d9019109dfa10486befb4920d548", @"/Areas/Identity/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"126e99323545403694cb3d7348c7023d832852f717ca580af17f8f954be5f438", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
#nullable restore
#line 10 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 13 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
#line 15 "C:\Users\USER\OneDrive\Masaüstü\Yeni klasör\HastaneOtomasyonu-master\HastaneBilgiSistemi\HastaneBilgiSistemi\Areas\Identity\Pages\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
