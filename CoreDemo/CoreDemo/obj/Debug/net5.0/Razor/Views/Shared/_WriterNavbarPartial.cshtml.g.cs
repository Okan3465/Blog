#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\CoreDemo\CoreDemo\Views\Shared\_WriterNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b55d0af5756bb0b956fbc18c2cae5d54678e8af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WriterNavbarPartial), @"mvc.1.0.view", @"/Views/Shared/_WriterNavbarPartial.cshtml")]
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
#line 1 "C:\Users\Okan Karakoç\Documents\GitHub\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b55d0af5756bb0b956fbc18c2cae5d54678e8af", @"/Views/Shared/_WriterNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__WriterNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div asp-controller=""Writer"" asp-action=""WriterNavbarPartial"" >

    <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
        <ul class=""nav"">
            <li class=""nav-item nav-profile"">
                <a href=""#"" class=""nav-link"">
                    <div class=""nav-profile-image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b55d0af5756bb0b956fbc18c2cae5d54678e8af4237", async() => {
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
            WriteLiteral(@"
                        <span class=""login-status online""></span>
                        <!--change to offline or busy as needed-->
                    </div>
                    <div class=""nav-profile-text d-flex flex-column"">
                        <span class=""font-weight-bold mb-2"">Yazar Adı ve Soyadı</span>
                        <span class=""text-secondary text-small"">Yazılım Mühendisi</span>
                    </div>
                    <i class=""mdi mdi-bookmark-check text-success nav-profile-badge""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""../../index.html"">
                    <span class=""menu-title"">Dashboard</span>
                    <i class=""mdi mdi-home menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""../../pages/icons/mdi.html"">
                    <span class=""menu-title"">Profilim</span>
                    ");
            WriteLiteral(@"<i class=""mdi mdi-contacts menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Blog/BlogListByWriter"">
                    <span class=""menu-title"">Bloglarım</span>
                    <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Blog/BlogAdd"">
                    <span class=""menu-title"">Yeni Blog</span>
                    <i class=""mdi mdi-chart-bar menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                    <span class=""menu-title"">Mesajlar</span>
                    <i class=""mdi mdi-message menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""../../pages/tables/basic-table.htm");
            WriteLiteral(@"l"">
                    <span class=""menu-title"">Siteye Git</span>
                    <i class=""mdi mdi-car menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                    <span class=""menu-title"">Ayarlar</span>
                    <i class=""mdi mdi-settings menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                    <span class=""menu-title"">Çıkış Yap</span>
                    <i class=""mdi mdi-logout-variant menu-icon""></i>
                </a>
            </li>
        </ul>
    </nav>
</div>");
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
