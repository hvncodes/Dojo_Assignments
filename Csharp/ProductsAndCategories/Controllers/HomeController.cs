using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAndCategories.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private ProductsAndCategoriesContext db;
        public HomeController(ProductsAndCategoriesContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("Category");
        }

        [HttpGet("/products")]
        public IActionResult Product()
        {
            List<Product> AllProducts = db.Products
                .ToList();
                ViewBag.AllProducts = AllProducts;
            return View("Products");
        }

        [HttpPost("/products")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if (ModelState.IsValid == false)
            {
                List<Product> AllProducts = db.Products
                    .ToList();
                    ViewBag.AllProducts = AllProducts;
                return View("Products");
            }
            
            db.Add(newProduct);
            db.SaveChanges();
            return RedirectToAction("Product");
        }

        [HttpGet("/products/{prodId}")]
        public IActionResult ReadProduct(int prodId)
        {
            var ProdWithCat = db.Products
                .Include(p => p.CategoryProducts)
                    .ThenInclude(cp => cp.Category)
                .FirstOrDefault(prod => prod.ProductId == prodId);
            ViewBag.ProductWithCategories = ProdWithCat;
            var FreeCats = db.Categories
                .Include(c => c.CategoryProducts)
                .Where(c => c.CategoryProducts.All
                    (
                        p => p.ProductId != prodId
                    )
                ).ToList();
            ViewBag.FreeCategories = FreeCats;
            return View("Product");
        }

        [HttpPost("/products/{prodId}")]
        public IActionResult UpdateCategoryProduct(CategoryProduct newCatProd, int prodId)
        {
            db.Add(newCatProd);
            newCatProd.ProductId = prodId;
            db.SaveChanges();
            return RedirectToAction("ReadProduct", new { prodId = prodId });
        }

        [HttpGet("/categories")]
        public IActionResult Category()
        {
            List<Category> AllCategories = db.Categories
                .ToList();
                ViewBag.AllCategories = AllCategories;
            return View("Categories");
        }

        [HttpPost("/categories")]
        public IActionResult CreateCategory(Category newCategory)
        {
            if (ModelState.IsValid == false)
            {
                List<Category> AllCategories = db.Categories
                    .ToList();
                    ViewBag.AllCategories = AllCategories;
                return View("Categories");
            }
            
            db.Add(newCategory);
            db.SaveChanges();
            return RedirectToAction("Categories");
        }

        [HttpGet("/categories/{catId}")]
        public IActionResult ReadCategory(int catId)
        {
            var CatWithProd = db.Categories
                .Include(p => p.CategoryProducts)
                    .ThenInclude(cp => cp.Product)
                .FirstOrDefault(cat => cat.CategoryId == catId);
            ViewBag.CategoryWithProducts = CatWithProd;
            var FreeProds = db.Products
                .Include(c => c.CategoryProducts)
                .Where(c => c.CategoryProducts.All
                    (
                        c => c.CategoryId != catId
                    )
                ).ToList();
            ViewBag.FreeProducts = FreeProds;
            return View("Category");
        }

        [HttpPost("/products/{catId}")]
        public IActionResult AddCategoryProduct(CategoryProduct newCatProd, int catId)
        {
            db.Add(newCatProd);
            newCatProd.CategoryId = catId;
            db.SaveChanges();
            return RedirectToAction("ReadCategory", new { catId = catId });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
