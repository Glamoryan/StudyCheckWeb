#pragma checksum "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ae54c28efd344d2ca8cb7fbec68fbdc3ca0f2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Rol_RolListesi), @"mvc.1.0.view", @"/Areas/Administrator/Views/Rol/RolListesi.cshtml")]
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
#line 1 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using StudyCheckWeb.MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ae54c28efd344d2ca8cb7fbec68fbdc3ca0f2d", @"/Areas/Administrator/Views/Rol/RolListesi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b140010cfc99635a180e8ef57fce3d7e5fa193", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Rol_RolListesi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables-responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables-responsive/js/responsive.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
  
    ViewData["Title"] = "Rol Listesi";
    Layout = "~/Areas/Administrator/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Rol Listesi</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Rol İşlemleri</a></li>
                    <li class=""breadcrumb-item active"">Rol Listesi</li>
                </ol>
            </div>
        </div>
    </div>
</section>

<section class=""content"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Tüm Roller</h3>
                </div>
                <!-- /.card-header -->
                <div class=""card-body"">
                    <table id=""rolTable"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                    ");
            WriteLiteral(@"            <th class=""text-center"">Rol Id</th>
                                <th>Rol Adı</th>
                                <th>Kayıt Tarihi</th>
                                <th>Rolü Ekleyen</th>
                                <th>Rol Yetkisi</th>
                                <th>Durum</th>
                                <th class=""text-center"">İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 45 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                             foreach (var rol in Model.roller)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td style=\"color:#ff5311;\" class=\"text-center\">");
#nullable restore
#line 48 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                                                                              Write(rol.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                                   Write(rol.rol_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                                   Write(rol.rol_kayit_tarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 51 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                                   Write(Model.kullanicilar.Where(k=>k.id==rol.ekleyen_id).Single().kullanici_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 52 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                                   Write(Model.yetkiler.Where(y=>y.id == rol.yetki_id).Single().yetki_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("style", " style=\"", 2277, "\"", 2333, 1);
#nullable restore
#line 53 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
WriteAttributeValue("", 2285, rol.sil_id==0?"color:red;":"color:limegreen;", 2285, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                                                                                             Write(rol.sil_id == 1 ? "Aktif":"Pasif");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\"><i style=\"color:#ff5311;\" class=\"fas fa-cog\"></i></td>\r\n                                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Rol\RolListesi.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- /.card-body -->\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n        <!-- /.card -->\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!-- DataTables -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ae54c28efd344d2ca8cb7fbec68fbdc3ca0f2d10911", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ae54c28efd344d2ca8cb7fbec68fbdc3ca0f2d12011", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ae54c28efd344d2ca8cb7fbec68fbdc3ca0f2d13111", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ae54c28efd344d2ca8cb7fbec68fbdc3ca0f2d14211", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#rolTable"").DataTable({
                ""language"": {
                    ""info"": ""Toplam: _TOTAL_ veri mevcut"",
                    ""infoEmpty"": ""Gösterilecek veri yok"",
                    ""infoFiltered"": "" - _MAX_ veriden filtrelendi"",
                    ""lengthMenu"": ""Göster _MENU_ Roller"",
                    ""search"": ""Ara:"",
                    ""zeroRecords"": ""Kayıt bulunamadı"",
                    ""paginate"": {
                        ""previous"": ""Önceki"",
                        ""next"": ""Sonraki""
                    },
                },
                ""responsive"": true,
                ""autoWidth"": false,
                ""paging"": true,
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
