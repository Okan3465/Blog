#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e5cb101065271a838d802d7946242e25a21626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotifications), @"mvc.1.0.view", @"/Views/Notification/AllNotifications.cshtml")]
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
#line 1 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e5cb101065271a838d802d7946242e25a21626", @"/Views/Notification/AllNotifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_AllNotifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
  
    ViewData["Title"] = "AllNotifications";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tüm Bildirimler</h1>\r\n\r\n<table class=\"table table-bordered bg-dark text-warning \">\r\n    <tr>\r\n        <td>#</td>\r\n        <td>Bildirim Detayları</td>\r\n        <td>Tarih</td>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
   Write(item.NotificationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
   Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
   Write(item.NotificationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 24 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591