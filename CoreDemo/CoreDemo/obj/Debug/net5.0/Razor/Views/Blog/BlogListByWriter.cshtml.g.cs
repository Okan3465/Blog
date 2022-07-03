#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a5aed0ce8e5e1e634c59d71cfcb7f9637937d53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a5aed0ce8e5e1e634c59d71cfcb7f9637937d53", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazarın Blogları</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog Başlığı</th>
        <th>Oluşturma Tarihi</th>
        <th>Kategori</th>
        <th>Durum</th>
        <th>Sil</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 689, "\"", 725, 2);
            WriteAttributeValue("", 696, "/Blog/DeleteBlog/", 696, 17, true);
#nullable restore
#line 29 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 713, item.BlogID, 713, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 774, "\"", 808, 2);
            WriteAttributeValue("", 781, "/Blog/EditBlog/", 781, 15, true);
#nullable restore
#line 30 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 796, item.BlogID, 796, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n</tr>\r\n");
#nullable restore
#line 32 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br /><br />\r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-primary\">Yeni Blog Oluştur</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
