using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SencondMvc.Models;

namespace SencondMvc.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new() {
            new Product() { Name = "product1", Description = "desc1", Price = 10 },
            new Product() { Name = "product2", Description = "desc2", Price = 20 },
            new Product() { Name = "product3", Description = "desc3", Price = 30 },
            new Product() { Name = "product4", Description = "desc4", Price = 40 },
            new Product() { Name = "product5", Description = "desc5", Price = 50 },
            new Product() { Name = "product6", Description = "desc6", Price = 60 }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
           
            return View(products);
        }
        
        public ProductController()
        {
        }
        public IActionResult Get(Product product)
        {
            
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Get()
        //{
        //    var a = Request.Query["a"].ToString();
        //    var b = Request.Query["b"].ToString();
        //    return View();
        //}

        //public IActionResult Get(string a, string b) { return View(); }
        [HttpGet]
        public IActionResult Delete()
        {
            var model = new ProductViewModel();
            products.ForEach(p => model.Products.Add(new SelectListItem() { Value = p.Name,Text = p.Name }));
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(ProductViewModel pvm)
        {
            var product = pvm.Product;
            var producctt = new Product();

            foreach (var item in products)
            {
                if(item.Name == product)
                {
                    producctt = item;
                }
            }

            products.Remove(producctt);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");
        }
    }
}
