#pragma checksum "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b6daead089967149d94e041c767321203af6365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\_ViewImports.cshtml"
using StudyCheckWeb.MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\_ViewImports.cshtml"
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b6daead089967149d94e041c767321203af6365", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef96754046a7a330624bd17be0715e70641d91b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/VisitorPage/images/logo2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("StudyCheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "sign", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CikisYap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link page-scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/VisitorPage/images/laptop.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("alternative"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/VisitorPage/images/features-iphone-1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Hoşgeldiniz";
    Layout = "_VisitorLayout";
    ClaimsPrincipal currentUser = this.User;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Preloader -->
<div class=""spinner-wrapper"">
    <div class=""spinner"">
        <div class=""bounce1""></div>
        <div class=""bounce2""></div>
        <div class=""bounce3""></div>
    </div>
</div>
<!-- end of preloader -->
<!-- Navigation -->
<nav class=""navbar navbar-expand-md navbar-dark navbar-custom fixed-top"">
    <!-- Text Logo - Use this if you don't have a graphic logo -->
    <!-- <a class=""navbar-brand logo-text page-scroll"" href=""index.html"">Leno</a> -->
    <!-- Image Logo -->
    <a class=""navbar-brand logo-image"" href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b6daead089967149d94e041c767321203af63658336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>

    <!-- Mobile Menu Toggle Button -->
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExampleDefault"" aria-controls=""navbarsExampleDefault"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-awesome fas fa-bars""></span>
        <span class=""navbar-toggler-awesome fas fa-times""></span>
    </button>
    <!-- end of mobile menu toggle button -->

    <div class=""collapse navbar-collapse"" id=""navbarsExampleDefault"">
        <ul class=""navbar-nav ml-auto"">
            <li class=""nav-item"">
                <a class=""nav-link page-scroll"" href=""#header"">ANASAYFA<span class=""sr-only"">(current)</span></a>
            </li>

");
#nullable restore
#line 37 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\Home\Index.cshtml"
             if (currentUser.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b6daead089967149d94e041c767321203af636510544", async() => {
                WriteLiteral("Çıkış YAP");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 42 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b6daead089967149d94e041c767321203af636512529", async() => {
                WriteLiteral("GİRİŞ YAP");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 48 "C:\Users\Xsabr\source\repos\StudyCheckWeb\StudyCheckWeb.MvcWebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- Dropdown Menu -->\r\n");
            WriteLiteral(@"            <!-- end of dropdown menu -->

        </ul>
    </div>
</nav> <!-- end of navbar -->
<!-- end of navigation -->
<!-- Header -->
<header id=""header"" class=""header"">
    <div class=""header-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""text-container"">
                        <h1>STUDYCHECK <br><span id=""js-rotating"">ÖĞRENCİLER, DERSHANELER, OKULLAR</span><br /> için</h1>
                        <p class=""p-large"">StudyCheck bir çalışma ve analiz programıdır. Şimdi masaüstü uygulamasını indirin!</p>
                        <a class=""btn-solid-lg page-scroll"" href=""https://github.com/Glamoryan/StudyCheck/releases"" target=""_blank""><i class=""fab fa-windows""></i> Windows 10</a>
                    </div>
                </div> <!-- end of col -->
                <div class=""col-lg-6"" style=""margin-top:110px"">
                    <div class=""image-container"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b6daead089967149d94e041c767321203af636515542", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div> <!-- end of image-container -->
                </div> <!-- end of col -->
            </div> <!-- end of row -->
        </div> <!-- end of container -->
    </div> <!-- end of header-content -->
</header> <!-- end of header -->
<!-- end of header -->
<!-- end of testimonials -->
<!-- Features -->
<div id=""features"" class=""tabs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2>ÖZELLİKLER</h2>
                <div class=""p-heading p-large"">StudyCheck bir çalışma ve analiz programıdır.</div>
            </div> <!-- end of col -->
        </div> <!-- end of row -->
        <div class=""row"">

            <!-- Tabs Links -->
            <ul class=""nav nav-tabs"" id=""lenoTabs"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""nav-tab-1"" data-toggle=""tab"" href=""#tab-1"" role=""tab"" aria-controls=""tab-1"" aria-selected=""true""><i class=""fas fa-cog""></i>AYA");
            WriteLiteral(@"RLAMALAR</a>
                </li>                
            </ul>
            <!-- end of tabs links -->
            <!-- Tabs Content-->
            <div class=""tab-content"" id=""lenoTabsContent"">

                <!-- Tab -->
                <div class=""tab-pane fade show active"" id=""tab-1"" role=""tabpanel"" aria-labelledby=""tab-1"">
                    <div class=""container"">
                        <div class=""row"">
                            <!-- Icon Cards Pane -->
                            <div class=""col-lg-4"">
                                <div class=""card left-pane first"">
                                    <div class=""card-body"">
                                        <div class=""text-wrapper"">
                                            <h4 class=""card-title"">Kurulumlar</h4>
                                            <p>
                                                Releases linkinden son yayınlanan versiyonu indirip kurulumu tamamlayın.
                                ");
            WriteLiteral(@"                Kurum sonrası gerekli bilgiler..
                                                <b>Kullanıcı Adı: admin Şifre: admin123</b>
                                            </p>
                                        </div>
                                        <div class=""card-icon"">
                                            <i class=""far fa-file-code""></i>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card left-pane"">
                                    <div class=""card-body"">
                                        <div class=""text-wrapper"">
                                            <h4 class=""card-title"">Kurulumlar(Build)</h4>
                                            <a href=""https://github.com/Glamoryan/StudyCheck"">Buraya</a>
                                        </div>
                                        <div class=""card-icon"">
       ");
            WriteLiteral(@"                                     <i class=""far fa-gem""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- end of icon cards pane -->
                            <!-- Image Pane -->
                            <div class=""col-lg-4"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b6daead089967149d94e041c767321203af636520416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <!-- end of image pane -->
                            <!-- Icon Cards Pane -->
                            <div class=""col-lg-4"">                                                                
                                <div class=""card right-pane first"">
                                    <div class=""card-body"">
                                        <div class=""card-icon"">
                                            <i class=""fas fa-cube""></i>
                                        </div>
                                        <div class=""text-wrapper"">
                                            <h4 class=""card-title"">Yeni Özellikler</h4>
                                            <p>
                                                Çalışmalarınızı kaydedebilir,
                                                Pomodora tekniği ile çalışabilir,
                                                Yönetimsel işlemler yapabili");
            WriteLiteral(@"rsiniz (Admin Panel)
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- end of icon cards pane -->

                        </div> <!-- end of row -->
                    </div> <!-- end of container -->
                </div> <!-- end of tab-pane -->
                <!-- end of tab -->               

            </div> <!-- end of tab-content -->
            <!-- end of tabs content -->

        </div> <!-- end of row -->
    </div> <!-- end of container -->
</div> <!-- end of tabs -->
<!-- end of features -->
<!-- end of video -->

<!-- Download -->
<div class=""basic-4"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-xl-5"">
                <div class=""text-container"">
                    <h2>Studycheck'i şimdi indirin</h2>
                    ");
            WriteLiteral(@"<p class=""p-large"">StudyCheck bir çalışma ve analiz programıdır. Şimdi masaüstü uygulamasını indirin!</p>
                    <a class=""btn-solid-lg"" href=""https://github.com/Glamoryan/StudyCheck/releases/tag/StudyCheckFull"" target=""_blank""><i class=""fab fa-windows""></i>Windows 10</a>                    
                </div> <!-- end of text-container -->
            </div> <!-- end of col -->
            <div class=""col-lg-6 col-xl-7"">
                <div class=""image-container"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b6daead089967149d94e041c767321203af636524277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div> <!-- end of img-container -->
            </div> <!-- end of col -->
        </div> <!-- end of row -->
    </div> <!-- end of container -->
</div> <!-- end of basic-4 -->
<!-- end of download -->
<!-- Footer -->
<div class=""footer"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""footer-col"">
                    <h4>StudyCheck Hakkında</h4>
                    <p>StudyCheck bir çalışma ve analiz programıdır.</p>
                </div>
            </div> <!-- end of col -->
            <div class=""col-md-4"">
                <div class=""footer-col middle"">
                    <h4>Önemli Bağlantılar</h4>
                    <ul class=""list-unstyled li-space-lg"">
                        <li class=""media"">
                            <i class=""fas fa-square""></i>
                            <div class=""media-body"">Kaynak Kodu (Web) <a target=""_blank"" class=""turquoise"" href=""https://github.com/Glamor");
            WriteLiteral(@"yan/StudyCheckWeb"">studycheck.web.com</a></div>
                        </li>
                        <li class=""media"">
                            <i class=""fas fa-square""></i>
                            <div class=""media-body"">Kaynak Kodu (Desktop) <a target=""_blank"" class=""turquoise"" href=""https://github.com/Glamoryan/StudyCheck"">studycheck.com</a></div>
                        </li>
                    </ul>
                </div>
            </div> <!-- end of col -->
            <div class=""col-md-4"">
                <div class=""footer-col last"">
                    <h4>Social</h4>
                    <span class=""fa-stack"">
                        <a href=""https://github.com/Glamoryan"" target=""_blank"">
                            <i class=""fas fa-circle fa-stack-2x""></i>
                            <i class=""fab fa-github fa-stack-1x""></i>
                        </a>
                    </span>                    
                </div>
            </div> <!-- end of col -->
    ");
            WriteLiteral(@"    </div> <!-- end of row -->
    </div> <!-- end of container -->
</div> <!-- end of footer -->
<!-- end of footer -->
<!-- Copyright -->
<div class=""copyright"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <p class=""p-small"">Copyright © 2020 <a href=""https://github.com/Glamoryan/StudyCheck"" target=""_blank"">StudyCheck</a> - All rights reserved</p>
            </div> <!-- end of col -->
        </div> <!-- enf of row -->
    </div> <!-- end of container -->
</div> <!-- end of copyright -->
<!-- end of copyright -->
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
