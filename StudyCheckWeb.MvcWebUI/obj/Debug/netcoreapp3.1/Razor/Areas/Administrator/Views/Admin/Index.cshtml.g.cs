#pragma checksum "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe44741321e767bc4867f20dbdf29975d1d6baec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Admin_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe44741321e767bc4867f20dbdf29975d1d6baec", @"/Areas/Administrator/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab18d3aa7391461f63b7ccf2ff9d2a22bcf08dfb", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Areas\Administrator\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin Panel";
    Layout = "~/Areas/Administrator/Views/Shared/_AdminLayout.cshtml";

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
                    <li class=""breadcrumb-item""><a href=""#"">Anasayfa</a></li>
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
  ");
            WriteLiteral(@"                  <div class=""info-box-content"">
                        <span class=""info-box-text"">Kullanıcılar</span>
                        <span class=""info-box-number"">
                            0
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
                        <span class=""info-box-number"">0</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
         ");
            WriteLiteral(@"   <!-- fix for small devices only -->
            <div class=""clearfix hidden-md-up""></div>
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-success elevation-1""><i class=""fas fa-paste""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Sınavlar</span>
                        <span class=""info-box-number"">0</span>
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
                       ");
            WriteLiteral(@" <span class=""info-box-number"">1</span>
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
                            0
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-info elevation-1""><i cl");
            WriteLiteral(@"ass=""fas fa-user-tag""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Roller</span>
                        <span class=""info-box-number"">
                            0
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
                            0
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!");
            WriteLiteral("-- /.info-box -->\r\n            </div>\r\n            <!-- /.col -->\r\n        </div>\r\n        <!-- /.row -->        \r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n<!-- /.content -->\r\n");
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
