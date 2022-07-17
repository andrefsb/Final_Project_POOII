using CsvHelper.Configuration;
using LetsMarket.Entities;


namespace LetsMarket.Faker
{
    public class CsvReaderClassMap : ClassMap<Product>
    {
        public CsvReaderClassMap()
        {
            Map(m => m.ProductCode).Name("codbar");
            Map(m => m.Description).Name("desc_sem_acento");
            Map(m => m.Price).Ignore();
        }
    }
}