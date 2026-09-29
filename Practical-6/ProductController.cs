using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalogMVC.Models;

namespace ProductCatalogMVC.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Price = 25000,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Price = 2000,
                    Category = "Accessories"
                }
            };

            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product product = new Product();

            if (id == 1)
            {
                product = new Product
                {
                Id = 1,
                    Name = "Laptop",
                    Price = 55000,
                    Category = "Electronics"
                };
            }
            else if (id == 2)
            {
                product = new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Price = 25000,
                    Category = "Electronics"
                };
            }
            else
            {
                product = new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Price = 2000,
                    Category = "Accessories"
                };
            }

            return View(product);
        }
    }
}
