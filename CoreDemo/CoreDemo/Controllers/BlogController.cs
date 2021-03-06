using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values =bm.GetListWithCategoryByWriterBm(3); //GetListByWriter metodu BlogManager'da özel olarak tanımlanmıştı 
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
           

            List<SelectListItem> categoryvalues = (from x in cm.GetList()           //Dropdown işlemleri burada yapıldı
                                                   select new SelectListItem               
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryvalues; //viewbag'le categoryvaluesdaki değerleri dropdowna taşıyabiliriz.
            return View();
        }
        [HttpPost]

        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;        //Status ve about kısmı index de olmadığı için controllerdan gönderdik boş geçmemesi için
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 3 ;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog"); //Blog controllerdaki index sayfasına gönder

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());

            List<SelectListItem> categoryvalues = (from x in cm.GetList()           //Dropdown işlemleri burada yapıldı
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryvalues; //viewbag'le categoryvaluesdaki değerleri dropdowna taşıyabiliriz.
            


            return View(p);
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.TGetById(id);
            bm.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]

        public IActionResult EditBlog(int id)
        {
            var blogvalue = bm.TGetById(id);

            List<SelectListItem> categoryvalues = (from x in cm.GetList()           //Dropdown işlemleri burada yapıldı
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryvalues; //viewbag'le categoryvaluesdaki değerleri dropdowna taşıyabiliriz.
          
            return View(blogvalue);


                                  //Düzenleme işlemi yapabilmek için öncelikle
                                  //id'nin find bulma işleminin yapılması gerekir
        }
      
        [HttpPost]

        public IActionResult EditBlog(Blog p)
        {
            p.WriterID = 3;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
