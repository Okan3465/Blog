#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e90c739dfa15a0ad05bb0f4a4ab6f75d83bac6ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90c739dfa15a0ad05bb0f4a4ab6f75d83bac6ce", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Okan Karakoç\Documents\GitHub\Blog\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yazar Ajax İşlemleri</h1>\r\n<br />\r\n<button type=\"button\" id=\"btngetlist\" class=\"btn btn-outline-primary\">Yazar Listesi</button>  ");
            WriteLiteral(@"
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar Getir</button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar Ekle</button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Yazarı Sil</button>
<button type=""button"" id=""btnupdateewriter"" class=""btn btn-outline-warning"">Yazarı Güncelle</button>
<br />
<br />

<div id=""writerlist"">

    Buraya yazarlar gelecek

</div>
<br />
<div id=""writerget"">


</div>
<div>Yazar ID'sine Göre Yazar Getirme İşlemi İçin</div>

<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar ID Değerini Girin"" class=""form-control"" />
</div>
<br />

<div>Yazar Ekleme İşlemi İçin</div>
<div>

    <input type=""text"" class=""form-control"" id=""txtwriterid"" placeholder=""Yazar ID"" />

    <input type=""text"" class=""form-control"" id=""txtwritername"" placeholder=""Yazar Adı"" />
    <br />

</div>

<br />
<div>Yazar Silme İşlemi İçin</div>
<div>
    <input type=""text"" class=""for");
            WriteLiteral(@"m-control"" id=""txtid"" placeholder=""Silinecek Yazar ID"" />
</div>
<br />
<div>Yazar Güncelleme İşlemi İçin</div>
<input type=""text"" id=""txtid1"" class=""form-control"" placeholder=""Güncellenecek ID"" />
<input type=""text"" id=""txtwritername1"" class=""form-control"" placeholder=""Güncellenecek İsim"" />


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>



        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);

                    let tablehtml = ""<table class=table table-bordered> <tr> <th>Yazar ID </th> <th>Yazar Adı</th> </tr>"";

                    $.each(w, (index, value) => {
                        tablehtml += `<tr> <td>${value.Id} </td> <td>${value.Name}</td > </tr>`

                    });

                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        }); //btngetlist  liste getirme

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();  //console ekranına  yazdığımız değeri getirir

            $.a");
                WriteLiteral(@"jax({  // burada yapılacak olan işlemle listede bulunan ve id'ye göre istediğimiz değer gelecek

                contentType: ""application/json"",
                dataType: ""json"",
                type: ""get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func)  //istediğimiz değeri console ekranında farklı bir liste şeklinde çeviriyor
                    console.log(w);

                    let getvalue = `<table class=table table-bordered> <tr> <th>Yazar ID </th> <th> Yazar Adı</th>  </tr> <tr> <td>${w.Id} </td> <td> ${w.Name} </td> </tr> </table>`;
                    // yukarıda id'si writerget olan div içerisine getirmek istediğimiz değeri yazıyoruz
                    $(""#writerget"").html(getvalue);
                }
            });
        }); //btngetbyıd  yazar getirme

        $(""#btnaddwriter"").click(function () {

            let writer = {

  ");
                WriteLiteral(@"              Id: $(""#txtwriterid"").val(),
                Name: $(""#txtwritername"").val()

            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar Ekleme İşlemi Başarıyla Gerçekleşti"")
                }
            });


        }); //btnaddwriter ekleme işlemi

        $(""#btndeletewriter"").click(x => {

            let id = $(""#txtid"").val();

            $.ajax({

                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar Silme İşlemi BAşarıyla Gerçekleşti"");
                }


            });

        }); //btnwriterdelete silme işlemi

        $(""#btnupdateewriter"").click(function () {

            let writer =");
                WriteLiteral(@" {

                Id: $(""#txtid1"").val(),
                Name: $(""#txtwritername1"").val()

            };

            $.ajax({

                type: ""post"",
                url: ""/Admin/Writer/UpdateWriter/"",
                data: writer,
                success: function (func) {
                    alert(""Güncelleme İşlemi Gerçekleşti"");
                }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
