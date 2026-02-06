using KASHOP.Data;
using KASHOP.Models;
using Microsoft.AspNetCore.Mvc;

namespace KASHOP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            //ViewData["categories"] = context.Categories.ToList();
            ViewBag.Categories = context.Categories.ToList();
            return View();
        }

        //public IActionResult Store(Product request, IFormFile Image)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    //    var category = context.Products.Add(request);
        //    //    context.SaveChanges();
        //    //    return RedirectToAction(nameof(Index));
        //    //}
        //    //return View("create", request);   
        //    return Content("ok");
        //}

    }
}
