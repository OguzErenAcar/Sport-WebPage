#pragma checksum "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "853862d6467e7d895eaee0053b34a8230a0c8bd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMenuler_SliderListe), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMenuler/SliderListe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"853862d6467e7d895eaee0053b34a8230a0c8bd5", @"/Areas/Admin/Views/AdminMenuler/SliderListe.cshtml")]
    public class Areas_Admin_Views_AdminMenuler_SliderListe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSite.Models.Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vue/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/axios/axios.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <h3 class=""panel-title"">Slider Listesi / <a style=""color:red;"" >Slider </a></h3>
        <ul class=""panel-controls"">
            <li><a href=""#"" class=""panel-collapse""><span class=""fa fa-angle-down""></span></a></li>
            <li><a href=""#"" class=""panel-refresh""><span class=""fa fa-refresh""></span></a></li>
            <li><a href=""#"" class=""panel-remove""><span class=""fa fa-times""></span></a></li>
        </ul>
    </div>
    <div class=""panel-body"">
        <table class=""table "" id=""sliderlist"">
            <thead>
                <tr>
                    <th>Eklenme Tarih</th>
                    <th>Slider başlığı</th> 
                    <th>Resim yolu </th> 
                    <th style=""width:200px"">Araçlar</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>  ");
#nullable restore
#line 30 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml"
                         Write(item.Eklenmetarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 31 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml"
                        Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                         <td>");
#nullable restore
#line 32 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml"
                        Write(item.Resim);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n          \r\n                        <td>\r\n                            <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("v-on:click", " v-on:click=\"", 1353, "\"", 1386, 3);
            WriteAttributeValue(" ", 1366, "Slidersil(", 1367, 11, true);
#nullable restore
#line 35 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml"
WriteAttributeValue("", 1377, item.id, 1377, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1385, ")", 1385, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Sil  </button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\SliderListe.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853862d6467e7d895eaee0053b34a8230a0c8bd56770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853862d6467e7d895eaee0053b34a8230a0c8bd57809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    new Vue({
        el: ""#sliderlist"",
        data: {
        },
        methods: {
            Slidersil: function (id) {
                var vm = this;
                console.log(""SliderSil/"" + id);
                axios.get(""SliderSil/"" + id,)
                    .then(function (cevap) {
                        alert(cevap.data.message);
                        console.log(cevap.data);
                        location.href = ""SliderListe"";

                    }).catch(function (error) {
                        alert(error.data.message)

                    });


            }
        }
    });


</script>







");
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
