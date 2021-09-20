using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using CoffeeShopProduct.Models;

namespace CoffeeShopProduct.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = DAL.GetAllProducts();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            List<Product> prods = DAL.GetProducts(id);
            return View(prods);
        }

       

    }
}
