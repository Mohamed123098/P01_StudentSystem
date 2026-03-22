using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Data
{
    internal  static class DataSeeder
    {
        public static void DataSeedOfCustomers(ApplicationDbContext dbContext)
        {
            if(!dbContext.Customers.Any())
            {
                List<Customer> customers = new();
                customers.Add(new() { Name = "Muhammad Ragab", Email = "Muhammhu@gmail.com", CreditCardNumber = "1505808" });
                customers.Add(new() { Name = "Muhammad Yassin", Email = "Muhammhu@gmail.com", CreditCardNumber = "1505808" });
                customers.Add(new() { Name = "Yassmin Alaa", Email = "Muhammhu@gmail.com", CreditCardNumber = "1505808" });
                customers.Add(new() { Name = "Hamada Sayed", Email = "Muhammhu@gmail.com", CreditCardNumber = "1505808" });
                customers.Add(new() { Name = "Ahmed Kamal", Email = "Muhammhu@gmail.com", CreditCardNumber = "1505808" });
                dbContext.AddRange(customers);
            }
        }
        public static void DataSeedOfProducts(ApplicationDbContext dbContext)
        {
            if(!dbContext.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product { Name = "Laptop", Price = 999.99, Quantity = 50 },
                    new Product { Name = "Mouse", Price = 29.99, Quantity = 150 },
                    new Product { Name = "Keyboard", Price = 49.99, Quantity = 100 },
                    new Product { Name = "Monitor", Price = 299.99, Quantity = 30 },
                    new Product { Name = "Headphones", Price = 79.99, Quantity = 75 },
                    new Product { Name = "Webcam", Price = 59.99, Quantity = 60 },
                    new Product { Name = "USB Cable", Price = 9.99, Quantity = 200 },
                    new Product { Name = "Phone Charger", Price = 19.99, Quantity = 120 },
                    new Product { Name = "Tablet", Price = 499.99, Quantity = 40 },
                    new Product { Name = "Smartwatch", Price = 199.99, Quantity = 85 }
                };
                dbContext.AddRange(products);
            }
        }
        public static void DataSeedOfStores(ApplicationDbContext dbContext)
        {
            if(!dbContext.Stores.Any())
            {
                var stores = new List<Store>
                {
                    new Store { Name = "Cairo Store" },
                    new Store { Name = "Alex Store" },
                    new Store { Name = "Giza Store" },
                    new Store { Name = "Mansoura Store" },
                    new Store { Name = "Luxor Store" }
                };
                dbContext.AddRange(stores);
            }    

        }
        public static void DataSeedOfSales(ApplicationDbContext dbContext)
        {
           if(!dbContext.Sales.Any())
            {
                List<Sale> sales = new()
                    {
                      new(){ CustomerId=1, ProductId=1, StoreId=1},
                      new(){ CustomerId=2, ProductId=2, StoreId=2},
                      new(){ CustomerId=3, ProductId=3, StoreId=3}
                    };
                dbContext.AddRange(sales);
            }
        }
        public static void SavingDB(ApplicationDbContext dbContext)
        {
            dbContext.SaveChanges();
        }
    }
}
