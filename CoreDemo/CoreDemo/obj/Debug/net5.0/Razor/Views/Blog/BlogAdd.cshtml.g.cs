#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0372b95d66a29b4f57d1b392ed26dac5ae8391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
#line 1 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0372b95d66a29b4f57d1b392ed26dac5ae8391", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Blog Girişi</h1>\r\n<br /><br />\r\n");
#nullable restore
#line 10 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
 {   
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle,new  { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x=>x.Image,new  {@class="form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Küçük Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x=>x.ThumbNailImage,new {@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID,(List<SelectListItem>)ViewBag.cv,new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 33 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent,15,3, new  {@class="form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-info\">Yazıyı Kaydet</button>\r\n");
#nullable restore
#line 40 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
