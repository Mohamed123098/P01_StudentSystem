using P02_SalesDatabase.Data;

namespace P02_SalesDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext=new ApplicationDbContext())
            {
                DataSeeder.DataSeedOfProducts(dbContext);
                DataSeeder.DataSeedOfStores(dbContext);
                DataSeeder.DataSeedOfCustomers(dbContext);
                DataSeeder.SavingDB(dbContext);
                DataSeeder.DataSeedOfSales(dbContext);
                DataSeeder.SavingDB(dbContext);
            }
            
        }
    }
}
