using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchWorkFinal.Models;

namespace SearchWorkFinal.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search(string keyword)
        {
            var db = new ShopDbEntities();
            var products = db.Products.Where(p=> p.Name.Contains(keyword));


            return PartialView(products);
        }
    }
}
