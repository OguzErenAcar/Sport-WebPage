#pragma checksum "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Haber\HaberDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52604d46d744ad90f3b2e5d34077d6dee51c96e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Haber_HaberDetay), @"mvc.1.0.view", @"/Views/Haber/HaberDetay.cshtml")]
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
#line 1 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\_ViewImports.cshtml"
using WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\_ViewImports.cshtml"
using WebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52604d46d744ad90f3b2e5d34077d6dee51c96e8", @"/Views/Haber/HaberDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9751a11891ba42cf18e84a4b82e03210f652818", @"/Views/_ViewImports.cshtml")]
    public class Views_Haber_HaberDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSite.Models.Haberler>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<div class=""  "">

    <div class=""container d-flex h-100 mt-5 pb-4 "">

        <div class=""row justify-content-around align-self-center"">
            <div class=""col-9 mt-3 bg-dark a ""  >
                <div class=""pt-4 mt-4 text-start"">
                    <h1 class=""text-white w-75 mx-auto "">");
#nullable restore
#line 13 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Haber\HaberDetay.cshtml"
                                                    Write(Model.baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n                <img class=\"img-fluid d-flex mx-auto mt-5 w-75\"");
            BeginWriteAttribute("src", " src=\"", 450, "\"", 472, 1);
#nullable restore
#line 15 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Haber\HaberDetay.cshtml"
WriteAttributeValue("", 456, Model.Resimyolu, 456, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 473, "\"", 479, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                <p class=\"text-white w-75 mx-auto mt-5 pb-5\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Haber\HaberDetay.cshtml"
               Write(Model.icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n            </div>\r\n            <div class=\"col-3 m-auto\">\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSite.Models.Haberler> Html { get; private set; }
    }
}
#pragma warning restore 1591
