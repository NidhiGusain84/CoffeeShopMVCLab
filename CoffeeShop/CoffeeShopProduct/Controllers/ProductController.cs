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
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=JaiHanuman@84");
            List<Product> products = db.GetAll<Product>().ToList();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=JaiHanuman@84");
            List<Product> prod = db.Query<Product>("select * from products where id=@myId", new { myId = id }).ToList();
            return View(prod);
        }

    }
}
