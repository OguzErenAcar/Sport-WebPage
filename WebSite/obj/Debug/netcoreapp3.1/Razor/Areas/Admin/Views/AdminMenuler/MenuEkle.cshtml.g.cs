#pragma checksum "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\MenuEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0f28302bdc3180f2c439588541022e8bb3f500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMenuler_MenuEkle), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMenuler/MenuEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0f28302bdc3180f2c439588541022e8bb3f500", @"/Areas/Admin/Views/AdminMenuler/MenuEkle.cshtml")]
    public class Areas_Admin_Views_AdminMenuler_MenuEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSite.Models.Katagori>>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\MenuEkle.cshtml"
   var id = 1;
    if (Model.Any())
    {
        id = Model.OrderByDescending(a => a.id).FirstOrDefault().id + 1;
    }
    


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<tr id=""menuekle"">
    <td>
        Ekle:
    </td>
    <td>
        <input type=""text"" placeholder=""yeni isim"" v-model=""veriler.katagori"">
    </td>
    <td>
        <div class=""form-check"">

            <select data-val=""true"" data-val-number="" "" v-model=""veriler.Parentid"" name=""id"">
                <!--dropdown-->
                {
                <option");
            BeginWriteAttribute("value", " value=\"", 560, "\"", 568, 0);
            EndWriteAttribute();
            WriteLiteral(">Katagori seç</option>\r\n                }\r\n");
#nullable restore
#line 27 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\MenuEkle.cshtml"
                 foreach (var item in Model.Where(a => a.Parentid == null))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- tüm list yaz -->\r\n");
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 758, "\"", 774, 1);
#nullable restore
#line 30 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\MenuEkle.cshtml"
WriteAttributeValue("", 766, item.id, 766, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\MenuEkle.cshtml"
                                        Write(item.katagori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 31 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\MenuEkle.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </td>
    <td>
        <input type=""text"" v-model=""veriler.Link"" placeholder=""yeni isim"">
    </td>
    <td>
        <div class=""form-check"">
            <!----><input class=""form-check-input"" type=""checkbox"" v-model=""veriler.Aktifmi""");
            BeginWriteAttribute("id", " id=\"", 1105, "\"", 1110, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </td>\r\n    <td>\r\n\r\n        <button type=\"button\" class=\"btn btn-info btn-sm mybtn\" id=\" \" v-on:click=\"kaydet\">Kaydet</button>\r\n    </td>\r\n</tr>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b0f28302bdc3180f2c439588541022e8bb3f5006198", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b0f28302bdc3180f2c439588541022e8bb3f5007237", async() => {
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
            WriteLiteral("\r\n\r\n<script>\r\n\r\n    new Vue({\r\n        el: \"#menuekle\",\r\n        data: {\r\n            veriler: {\r\n                id: ");
#nullable restore
#line 59 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\MenuEkle.cshtml"
               Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
             },
            i:0,
        },
        methods:{
            kaydet: function () {
                var vm = this;
                vm.veriler.Parentid = parseInt(vm.veriler.Parentid);
                console.log(vm.veriler.id);
                console.log(vm.veriler.katagori);
                console.log(vm.veriler.Parentid);
                console.log(vm.veriler.Link);
                console.log(vm.veriler.Aktifmi);
                axios.post(""MenuKaydet"", vm.veriler).then(function (res) {
                    alert(res.data.message);
                    location.href = ""MenuY"";
                    }).catch(function (error) {
                        alert(error.data.message)

                    });
                }

            }

            } );








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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebSite.Models.Katagori>> Html { get; private set; }
    }
}
#pragma warning restore 1591
