#pragma checksum "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2874939bfb60030ec7ccb0dc302e590aad191ec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slider_Slider), @"mvc.1.0.view", @"/Views/Slider/Slider.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2874939bfb60030ec7ccb0dc302e590aad191ec6", @"/Views/Slider/Slider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9751a11891ba42cf18e84a4b82e03210f652818", @"/Views/_ViewImports.cshtml")]
    public class Views_Slider_Slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSite.Models.Slider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<div class=""container-fluid  pb-5 pt-4  "">
    <div class=""row  ms-3 d-flex justify-content-center  "">


        <div class=""col-lg-7 col-sm-10 mt-5  "">

            <div id=""carouselExampleIndicators"" class=""carousel slide  "">
                <div class=""carousel-indicators"">
                    <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slider 1""></button>
                  
");
#nullable restore
#line 16 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                      for (int i = 1; i < Model.Count(); i++)
                     { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"");
#nullable restore
#line 18 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-label=\"Slider 2\"></button>\r\n");
#nullable restore
#line 19 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n                <div class=\"carousel-inner  \">\r\n");
#nullable restore
#line 26 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                     foreach (var item in Model.Take(1))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1108, "\"", 1125, 1);
#nullable restore
#line 30 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
WriteAttributeValue("", 1114, item.Resim, 1114, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"...\">\r\n                            <div class=\"carousel-caption d-none d-md-block\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1273, "\"", 1290, 1);
#nullable restore
#line 32 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
WriteAttributeValue("", 1280, item.Link, 1280, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white\">\r\n                                    <h3 class=\"bg-dark\">");
#nullable restore
#line 33 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                                                   Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </a>\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                     foreach (var item in Model.Skip(1).Take(5))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item  \">\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1720, "\"", 1737, 1);
#nullable restore
#line 44 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
WriteAttributeValue("", 1726, item.Resim, 1726, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100 \" alt=\"...\">\r\n                            <div class=\"carousel-caption d-none d-md-block\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1886, "\"", 1903, 1);
#nullable restore
#line 46 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
WriteAttributeValue("", 1893, item.Link, 1893, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white\">\r\n                                    <h3 class=\"bg-dark\">");
#nullable restore
#line 47 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                                                   Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </a>\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 52 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>


                <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>


        </div>
            ");
#nullable restore
#line 68 "C:\Users\oguze\source\repos\WebSite\WebSite\Views\Slider\Slider.cshtml"
       Write(await Html.PartialAsync("~/Views/Slider/Fiksturtable.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebSite.Models.Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
