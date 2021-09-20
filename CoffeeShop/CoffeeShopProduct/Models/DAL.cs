using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace CoffeeShopProduct.Models
{
    public class DAL
    {
        //Database connection
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=JaiHanuman@84");

        public static List<Product> GetAllProducts()
        {
            return DB.GetAll<Product>().ToList();
        }

        public static List<Product> GetProducts(int id)
        {
            return DB.Query<Product>("select * from products where id = @myId", new { myId = id }).ToList();
        }

        public static Product GetOneProduct(int id)
        {
            return DB.Get<Product>(id);
        }

        public static void DeleteProduct(int id)
        {
            Product prod = new Product();
            prod.id = id;
            DB.Delete<Product>(prod);
        }

        public static void InsertAProduct(Product product)
        {
            DB.Insert<Product>(product);
        }

        public static void UpdatAProduct(Product product)
        {
            DB.Update<Product>(product);
        }


    }
}
