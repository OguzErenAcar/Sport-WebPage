#pragma checksum "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\HaberY.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2621285c1963f2421c4bbc3b1e2e9bb69e41623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMenuler_HaberY), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMenuler/HaberY.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2621285c1963f2421c4bbc3b1e2e9bb69e41623", @"/Areas/Admin/Views/AdminMenuler/HaberY.cshtml")]
    public class Areas_Admin_Views_AdminMenuler_HaberY : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\oguze\source\repos\WebSite\WebSite\Areas\Admin\Views\AdminMenuler\HaberY.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-content-wrap"">
    <div class=""row"">
        <div class=""col-md-12"">
            <form>
                <div class=""form-horizontal"" id=""haberCtrl"">

                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h3 class=""panel-title""><strong>Yeni Haber</strong> Ekle / <a style=""color:red;"" href=""/Admin/IcerikYonetimi/IcerikListele"">Geri</a></h3>
                            <ul class=""panel-controls"">
                                <li><a href=""#"" class=""panel-remove""><span class=""fa fa-times""></span></a></li>
                            </ul>
                        </div>

                        <div class=""panel-body"">

                            <div class=""form-group"">
                                <label class=""col-md-3 col-xs-12 control-label"">Takım </label>
                                <div class=""col-md-6 col-xs-12"">
                                    <div class=""input-group"">
    ");
            WriteLiteral("                                    <span class=\"input-group-addon\"><span");
            BeginWriteAttribute("class", " class=\"", 1163, "\"", 1171, 0);
            EndWriteAttribute();
            WriteLiteral(@"></span></span>
                                        <select data-val=""true"" v-on:change=""onChange($event)"" data-val-number="" "" name=""id"">
                                            <option value=""12"">Diğer</option>
                                            <option value=""8"">Galatasaray</option>
                                            <option value=""9"">Fenerbahce</option>
                                            <option value=""10"">Besiktas</option>
                                            <option value=""11"">Trabzonspor</option>
                                            o
                                        </select>
                                    </div>
                                    <span class=""help-block""></span>
                                </div> 
                            </div>
                            <div class=""form-group"">
                                <label class=""col-md-3 col-xs-12 control-label"">Resimli</label>
                           ");
            WriteLiteral(@"     <div class=""col-md-6 col-xs-12"">
                                  

                                    <input type=""file"" v-on:change=""resimsrc($event)"" id=""resim"" multiple>


                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-md-3 col-xs-12 control-label"">Baslik</label>
                                <div class=""col-md-6 col-xs-12"">
                                    <input type=""text"" cols=""80"" v-model=""haber.baslik"">
                                    <span class=""help-block""></span>
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""col-md-3 col-xs-12 control-label"">İçerik</label>
                                <div class=""col-md-6 col-xs-12"">

                                    <textarea class="" "" rows=""10"" cols=""80"" name=""Iceri");
            WriteLiteral("k\" v-model=\"haber.icerik\"></textarea>\r\n\r\n                                    <span class=\"help-block\"></span>\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n");
            WriteLiteral(@"
                        </div>

                        <div class=""panel-footer"">
                            <button class=""btn btn-default"">Temizle</button>

                        </div>
                        <button v-on:click=""haberpost"" type=""button""  class=""btn btn-primary pull-right"">Kaydet</button>
                    </div>
                </div>

            </form>

        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2621285c1963f2421c4bbc3b1e2e9bb69e416237756", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2621285c1963f2421c4bbc3b1e2e9bb69e416238795", async() => {
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
    var vue = new Vue({
        el: ""#haberCtrl"",
        data: {
            haber: {
                id: 0,
                icerik: """",
                baslik: """",
                Resimyolu: ""/Upload/Haberler/img/"",
                Takimid: 0,
            }
        
        },
        mounted: function () {
            this.haberpost;
            
        },

        
        methods: {
            resimsrc: function (event) {

                this.haber.Resimyolu = this.haber.Resimyolu + event.target.files[0].name;
            },
            haberpost: function () {
                var vm = this;
                //var fil = document.getElementById(""resim"");
                //vm.haber.Resimyolu = fil.value;
                
                //console.log(vm.haber);
                
                axios.post(""HaberYonetimi"", vm.haber)
                    .then(function (cevap) {
                        alert(cevap.data.message);
                        console.log");
            WriteLiteral(@"(cevap.data);

                    }).catch(function (error) { 
                        alert(error.data.message)

                    });

            },
            
            onChange: function (event) {
                   
                this.haber.Takimid = parseInt(event.target.value);
                 
                 console.log(this.haber.Takimid);
            } 
           


            
        }
    })

 

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
