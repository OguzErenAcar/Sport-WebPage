#pragma checksum "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b422aa196d7467fa719a0e391cb54a5b99b8c06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMenuler_menuler), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMenuler/menuler.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b422aa196d7467fa719a0e391cb54a5b99b8c06b", @"/Areas/Admin/Views/AdminMenuler/menuler.cshtml")]
    public class Areas_Admin_Views_AdminMenuler_menuler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSite.Models.Katagori>>
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
 foreach (var item in Model)
{

    string app = "app" + item.id;
    string id1 = "flexCheckIndeterminate1" + item.id;
    string id2 = "flexCheckIndeterminate2" + item.id;
    string id3 = "flexCheckIndeterminate3" + item.id;
    string mybtn = "mybt1" + item.id;
    string mybtn1 = "mybtn1" + item.id;
    string mybtn2 = "mybtn2" + item.id;
    string yeniad = "yeniad" + item.id;
    string selectbox = "selectbox" + item.id;






#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=", 515, "", 523, 1);
#nullable restore
#line 21 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 519, app, 519, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </td>\r\n            <td>\r\n                <h6>");
#nullable restore
#line 26 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
               Write(item.katagori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <input type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 683, "\"", 695, 1);
#nullable restore
#line 27 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 688, yeniad, 688, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" v-model=""veriler.katagori"" placeholder=""yeni isim"" disabled>
            </td>
            <td>
                <div class=""form-check"">
                        <!-- checkbox--><input class=""form-check-input""  v-on:change=""altmenu($event)""  type=""checkbox"" v-model=""veriler.Parentid""");
            BeginWriteAttribute("id", " id=\"", 984, "\"", 993, 1);
#nullable restore
#line 31 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 989, id1, 989, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n\r\n                                        <select data-val=\"true\" data-val-number=\" \"");
            BeginWriteAttribute("id", " id=\"", 1091, "\"", 1106, 1);
#nullable restore
#line 33 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 1096, selectbox, 1096, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" v-model=\"veriler.Parentid\" name=\"id\" disabled>\r\n                                            <!--dropdown-->\r\n");
#nullable restore
#line 35 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                             if(item.Parentid != null ) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--alt başlıksa ilk üst baslığını yaz -->\r\n                                                <option");
            BeginWriteAttribute("value", " value=\"", 1389, "\"", 1405, 1);
#nullable restore
#line 36 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 1397, item.id, 1397, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 36 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                                                     Write(Model.Where(a => a.id == item.Parentid).FirstOrDefault().katagori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 37 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("value", " value=\"", 1684, "\"", 1692, 0);
            EndWriteAttribute();
            WriteLiteral(">Katagori seç</option>\r\n");
#nullable restore
#line 41 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                             foreach (var item2 in Model.Where(a => a.Parentid == null && a.id != item.id))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- tüm list yaz -->\r\n");
            WriteLiteral("                                                    <option");
            BeginWriteAttribute("value", " value=\"", 2018, "\"", 2035, 1);
#nullable restore
#line 45 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 2026, item2.id, 2026, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                                                         Write(item2.katagori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 46 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </select>\r\n                </div>\r\n            </td>\r\n            <td>\r\n                <h6>");
#nullable restore
#line 53 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
               Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <input type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 2297, "\"", 2306, 1);
#nullable restore
#line 54 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 2302, id3, 2302, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" v-model=\"veriler.Link\" placeholder=\"yeni isim\" disabled>\r\n            </td>\r\n            <td>\r\n                <div class=\"form-check\">\r\n                    <!---->    <input class=\"form-check-input\" type=\"checkbox\" v-model=\"veriler.Aktifmi\"");
            BeginWriteAttribute("id", " id=\"", 2549, "\"", 2558, 1);
#nullable restore
#line 58 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 2554, id2, 2554, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                </div>\r\n            </td>\r\n            <td>\r\n                <button type=\"button\" class=\"btn btn-info btn-sm mybtn\"");
            BeginWriteAttribute("id", " id=\"", 2703, "\"", 2714, 1);
#nullable restore
#line 62 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 2708, mybtn, 2708, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" v-on:click=\"enable\">Düzenle</button>\r\n                  <button type=\"button\" class=\"btn btn-info btn-sm mybtn\"");
            BeginWriteAttribute("id", " id=\"", 2827, "\"", 2839, 1);
#nullable restore
#line 63 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 2832, mybtn1, 2832, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  v-on:click=\"sil\"  disabled> Sil </button>\r\n                  <button type=\"button\" class=\"btn btn-info btn-sm mybtn\"");
            BeginWriteAttribute("id", " id=\"", 2958, "\"", 2970, 1);
#nullable restore
#line 64 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
WriteAttributeValue("", 2963, mybtn2, 2963, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" v-on:click=\"kaydet\" disabled>Kaydet</button>\r\n            </td>\r\n        </tr>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b422aa196d7467fa719a0e391cb54a5b99b8c06b13015", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b422aa196d7467fa719a0e391cb54a5b99b8c06b14059", async() => {
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
            WriteLiteral("\r\n");
            WriteLiteral("    <script>\r\n\r\n        new Vue({\r\n            el: \'#app\' +");
#nullable restore
#line 74 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                   Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            data: {\r\n                i: 0,\r\n                veriler: {\r\n                    id: \"");
#nullable restore
#line 78 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                    Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    Link: \"\",\r\n                    Aktifmi: \"\",\r\n                    katagori: \"");
#nullable restore
#line 81 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                          Write(item.katagori);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    Parentid: \"");
#nullable restore
#line 82 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                          Write(item.Parentid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                },



            },
            mounted: function () {

                this.aktifmi();
            },
            methods: {
                kaydet: function () {
                    var vm = this;

                    vm.veriler.id = parseInt(vm.veriler.id);
                    vm.veriler.Parentid = parseInt(vm.veriler.Parentid);
                    

                    // tip dönüşümlerine dikkat et ..boolean ?
                    axios.post(""MenuKaydet"", vm.veriler).then(function (res) {
                        alert(res.data.message);
                        location.href = ""MenuY"";

                    }).catch(function (error) {
                        alert(error.data.message)
                        location.href = ""MenuY"";
                    });



                },
                altmenu: function () {
                    var vm = this;
                    var bool = vm.veriler.Parentid;
                    //doluysa
                    if (");
            WriteLiteral("bool != \"\") {\r\n                        //drop görünür\r\n                        document.getElementById(\"");
#nullable restore
#line 119 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                            Write(selectbox);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = false;\r\n                    }\r\n\r\n                    else {\r\n                        vm.veriler.Parentid = null;\r\n                        document.getElementById(\"");
#nullable restore
#line 124 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                            Write(selectbox);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = true;\r\n                    }\r\n                },\r\n\r\n                enable: function () {\r\n\r\n                    document.getElementById(\"");
#nullable restore
#line 130 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                        Write(id1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = false;\r\n                    document.getElementById(\"");
#nullable restore
#line 131 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                        Write(id2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = false;\r\n                    document.getElementById(\"");
#nullable restore
#line 132 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                        Write(id3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = false;\r\n                    document.getElementById(\"");
#nullable restore
#line 133 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                        Write(mybtn1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = false;\r\n                    document.getElementById(\"");
#nullable restore
#line 134 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                        Write(mybtn2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = false;\r\n                    document.getElementById(\"");
#nullable restore
#line 135 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                        Write(mybtn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = true;\r\n                    document.getElementById(\"");
#nullable restore
#line 136 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                                        Write(yeniad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = false;\r\n                    this.altmenu();\r\n                },\r\n\r\n                aktifmi: function () {\r\n                    var aktfmi = (\"");
#nullable restore
#line 141 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
                              Write(item.Aktifmi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" === 'True');
                    this.veriler.Aktifmi = aktfmi;

                },
                sil: function () {
                    var vm = this;
                    axios.get(""Menusil/""+vm.veriler.id).then(function (res) {
                        alert(res.data.message);
                        location.href = ""MenuY"";
                    }).catch(function (error) {
                        alert(error.data.message);
                        location.href = ""MenuY"";

                    });
                }
            }

        });


    </script>
");
#nullable restore
#line 162 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\menuler.cshtml"
}

#line default
#line hidden
#nullable disable
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
