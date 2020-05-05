#pragma checksum "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5c416b6f69d4278b143c3eb34a736c00ca5467"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Kullanici_KullaniciListesi), @"mvc.1.0.view", @"/Areas/Administrator/Views/Kullanici/KullaniciListesi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5c416b6f69d4278b143c3eb34a736c00ca5467", @"/Areas/Administrator/Views/Kullanici/KullaniciListesi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9136fd81a9cf30bd091754159ce60a4fae8cf8f9", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Kullanici_KullaniciListesi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityListModel>
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
#line 2 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
  
    ViewData["Title"] = "Kullanıcı Listesi";
    Layout = "~/Areas/Administrator/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Kullanıcı Listesi</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Kullanıcı İşlemleri</a></li>
                    <li class=""breadcrumb-item active"">Kullanıcı Listesi</li>
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
                    <h3 class=""card-title"">Tüm Kullanıcılar</h3>
                </div>
                <!-- /.card-header -->
                <div class=""card-body"">
                    <table id=""example1"" class=""table table-bordered table-striped"">
                        <thead>
                            <t");
            WriteLiteral(@"r>
                                <th class=""text-center"">Uye Id</th>
                                <th>Uye Adı</th>
                                <th>Uye Soyadı</th>
                                <th>Kullanıcı Adı</th>
                                <th>E-Mail</th>
                                <th>Kayıt Tarihi</th>
                                <th>Rol</th>
                                <th>Durum</th>
                                <th class=""text-center"">İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 47 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                             foreach (var item in Model.UserDetails)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\" style=\"color:#ff5311;\">");
#nullable restore
#line 50 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                                                              Write(item.uye_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 51 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                   Write(item.uye_ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 52 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                   Write(item.uye_soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 53 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                   Write(item.kullanici_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 54 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                   Write(item.kullanici_mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 55 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                   Write(item.kayit_tarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 56 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                   Write(Model.roller.Where(r=>r.id == item.rol_id).Single().rol_adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("style", " style=\"", 2480, "\"", 2539, 1);
#nullable restore
#line 57 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
WriteAttributeValue("", 2488, item.sil_id == 0?"color:red;":"color:limegreen;", 2488, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                                                                                                Write(item.sil_id == 1 ? "Aktif":"Pasif");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\"><i style=\"color:#ff5311;\" class=\"fas fa-cog\"></i></td>\r\n                                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Kullanici\KullaniciListesi.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- /.card-body -->\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n        <!-- /.card -->\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!-- DataTables -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5c416b6f69d4278b143c3eb34a736c00ca546711645", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5c416b6f69d4278b143c3eb34a736c00ca546712745", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5c416b6f69d4278b143c3eb34a736c00ca546713845", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5c416b6f69d4278b143c3eb34a736c00ca546714945", async() => {
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
            $(""#example1"").DataTable({
                ""language"": {
                    ""info"": ""Toplam _TOTAL_ veri mevcut."",
                    ""infoEmpty"": ""Gösterilecek veri yok"",
                    ""infoFiltered"": "" - _MAX_ veriden filtrelendi"",
                    ""lengthMenu"": ""Göster _MENU_ Kullanıcılar"",
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
            WriteLiteral("\r\n\r\n");
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
