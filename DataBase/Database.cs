using LetsMarket.Entities;
using LetsMarket.Validations;


namespace LetsMarket.DataBase
{
    public enum DatabaseOption { Employees, Products, Clients }

    public class Database
    {
        protected static readonly string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
        protected static readonly string employeesDb = Path.Combine(rootDirectory, "employees.xml");
        protected static readonly string productsDb = Path.Combine(rootDirectory, "products.xml");
        protected static readonly string clientsDb = Path.Combine(rootDirectory, "clients.xml");

        public static List<Employee> Employees = new List<Employee>();
        public static List<Product> Products = new List<Product>();
        public static List<Client> Clients = new List<Client>();

        static Database()
        {
            DatabaseValidation.ValidateDatabase();
            Load.LoadEmployee();
            Load.LoadProduct();
            Load.LoadClient();
        }

    }
}