using CoffeeShopProduct.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopProduct.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<Product> results = DAL.GetAllProducts();
            return View(results);
        }

        public IActionResult Description(int id)
        {

           List<Product> products = DAL.GetProducts(id);
            return View(products);

        }

        public IActionResult ProductForm()
        {
            return View();
        }
        public IActionResult AddProduct(Product product)
        {
            DAL.InsertAProduct(product);
            return Redirect("/Admin");
        }

        public IActionResult UpdateForm(int id)
        {            
            Product product = DAL.GetOneProduct(id);           
            return View(product);
        }

        public IActionResult EditProduct(Product product)
        {           
            DAL.UpdatAProduct(product);
            return Redirect("/Admin");
        }

        public IActionResult DeleteConfirmation(int id,
            string name, string description, float price, string category)
        {
            Product product = new Product();
            product.id = id;
            product.name = name;
            product.description = description;
            product.price = price;
            product.category = category;
            return View(product);
        }

        public IActionResult DeleteProduct(int id)
        {
            DAL.DeleteProduct(id);
            return Redirect("/Admin");
        }

    }
}
