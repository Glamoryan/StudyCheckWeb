#pragma checksum "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ed4a523f69bb718966ca3bb58af177944fb5a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Dashboard/Index.cshtml")]
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
#line 3 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ed4a523f69bb718966ca3bb58af177944fb5a4", @"/Areas/Administrator/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b140010cfc99635a180e8ef57fce3d7e5fa193", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("todo-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/adminPanel/todo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/adminPanel/Snake.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Admin Panel";
    Layout = "~/Areas/Administrator/Views/Shared/_AdminLayout.cshtml";

    int adminSayisi = 0;
    foreach (var rol in Model.roller.Where(r => r.yetki_id == 2).ToList())
    {
        adminSayisi += Model.kullanicilar.Where(k => k.rol_id == rol.id).Count();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0 text-dark"">Dashboard</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ed4a523f69bb718966ca3bb58af177944fb5a47262", async() => {
                WriteLiteral("Anasayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"">StudyCheck</li>
                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-primary elevation-1""><i class=""fas fa-users""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Kullanıcılar</span>
                        <span class=""info-box-number"">
                            ");
#nullable restore
#line 42 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
                       Write(Model.kullanicilar.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-secondary elevation-1""><i class=""fas fa-user-shield""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Adminler</span>
                        <span class=""info-box-number"">");
#nullable restore
#line 56 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
                                                 Write(adminSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <!-- fix for small devices only -->
            <div class=""clearfix hidden-md-up""></div>
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-success elevation-1""><i class=""fas fa-paste""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Sınavlar</span>
                        <span class=""info-box-number"">");
#nullable restore
#line 71 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
                                                 Write(Model.sinavlar.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-danger elevation-1""><i class=""fas fa-palette""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Temalar</span>
                        <span class=""info-box-number"">");
#nullable restore
#line 84 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
                                                 Write(Model.temalar.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-warning elevation-1""><i class=""far fa-sticky-note""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Dersler</span>
                        <span class=""info-box-number"">
                            ");
#nullable restore
#line 97 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
                       Write(Model.dersler.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-info elevation-1""><i class=""fas fa-user-tag""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Roller</span>
                        <span class=""info-box-number"">
                            ");
#nullable restore
#line 111 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
                       Write(Model.roller.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-dark elevation-1""><i class=""fas fa-address-card""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Yetkiler</span>
                        <span class=""info-box-number"">
                            ");
#nullable restore
#line 125 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Dashboard\Index.cshtml"
                       Write(Model.yetkiler.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
        </div>
        <div class=""row"">
            <section class=""col-lg-6 connectedSortable ui-sortable"">
                <!-- TO DO List -->
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""ion ion-clipboard mr-1""></i>
                            Yapılacaklar
                        </h3>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <ul id=""todoList"" class=""todo-list"" data-widget=""todo-list"">
                        </ul>
                    </div>
                    <!-- /.card-body -->
                    <div class=""card-footer clearfix"">
                    ");
            WriteLiteral(@"    <button data-toggle=""modal"" data-target=""#modal-default"" type=""button"" class=""btn btn-info float-right""><i class=""fas fa-plus""></i> Ekle</button>
                    </div>
                </div>
                <div class=""card bg-gradient-success"">
                    <div class=""card-header border-0 ui-sortable-handle"" style=""cursor: move;"">
                        <h3 class=""card-title"">
                            <i class=""far fa-calendar-alt""></i>
                            Takvim
                        </h3>
                        <!-- tools card -->
                        <div class=""card-tools"">
                            <!-- button with a dropdown -->
                            <button type=""button"" class=""btn btn-success btn-sm"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                        </div>
                        <!-- /. tools -->
                    </div>
                ");
            WriteLiteral(@"    <!-- /.card-header -->
                    <div class=""card-body pt-0"">
                        <!--The calendar -->
                        <div id=""calendar"" style=""width: 100%"">

                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </section>
            <section class=""col-lg-6 connectedSortable ui-sortable"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""fas fa-gamepad""></i>
                            Yılan Oyunu
                        </h3>
                    </div>
                    <div id=""gameBody"" class=""card-body"" style=""display:none;"">
                        <div class=""row"">
                            <div class=""col-7"">
                                <canvas id=""game"" width=""400"" height=""400""></canvas>
                            <");
            WriteLiteral(@"/div>
                            <div class=""col-3 ml-5"">
                                <h2 class=""text-center"">Skorlar</h2>
                                <hr />
                                <div>
                                    <ul style=""list-style-type: square;"" id=""skorlar"">
                                        
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /.card-body -->
                    <div class=""card-footer clearfix"">
                        <button id=""basla"" type=""button"" class=""btn btn-info float-left""><i class=""fas fa-play-circle""></i> Başlat</button>
                    </div>
                </div>
            </section>

        </div><!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>
<!-- /.content -->

<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
   ");
            WriteLiteral(@"     <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Yapılacak İşlem Ekle</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ed4a523f69bb718966ca3bb58af177944fb5a420205", async() => {
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n\r\n                    <div class=\"form-row\">\r\n                        <div class=\"form-group col-md-12\">\r\n                            <input class=\"form-control\" type=\"text\" id=\"mesaj\"");
                BeginWriteAttribute("value", " value=\"", 10287, "\"", 10295, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Başlık"" />
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-12"">
                            <input class=""form-control"" type=""text"" id=""sure""");
                BeginWriteAttribute("value", " value=\"", 10563, "\"", 10571, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Süre"" />
                        </div>
                    </div>
                </div>
                <div class=""modal-footer justify-content-between"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Kapat</button>
                    <button type=""submit"" class=""btn btn-primary"">Ekle</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <!-- /.modal-content -->\r\n    </div>\r\n    <!-- /.modal-dialog -->\r\n</div>\r\n<!-- /.modal -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ed4a523f69bb718966ca3bb58af177944fb5a422985", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    window.addEventListener(\"keydown\", function (e) {\r\n        // Yön tuşlarıyla scrool engelleme\r\n        if ([37, 38, 39, 40].indexOf(e.keyCode) > -1) {\r\n            e.preventDefault();\r\n        }\r\n    }, false);\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ed4a523f69bb718966ca3bb58af177944fb5a424280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
