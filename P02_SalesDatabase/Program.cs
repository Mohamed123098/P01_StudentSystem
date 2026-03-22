using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Data;
using P02_SalesDatabase.Models;
using System.Threading.Tasks;

namespace P02_SalesDatabase
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                //DataSeeder.DataSeedOfProducts(dbContext);
                //DataSeeder.DataSeedOfStores(dbContext);
                //DataSeeder.DataSeedOfCustomers(dbContext);
                //DataSeeder.SavingDB(dbContext);//to save before add foreign keys
                //DataSeeder.DataSeedOfSales(dbContext);
                //DataSeeder.SavingDB(dbContext);

                Customer customer = new();

                Console.WriteLine("Enter ur Name");
                customer.Name = Console.ReadLine()!;
                Console.WriteLine("Enter ur email ");
                customer.Email = Console.ReadLine()!;
                Console.WriteLine("Enter ur credit card number");
                customer.CreditCardNumber = Console.ReadLine()!;
                //dbContext.Add(customer); it is true 
                dbContext.Customers.Add(customer); //it is more readable
                DataSeeder.SavingDB(dbContext);
                //printing products in console 
                await dbContext.Customers.ForEachAsync(p =>
                {
                    Console.WriteLine(p);
                });

            }
            
        }
    }
}
