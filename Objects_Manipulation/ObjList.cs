using BetterConsoleTables;
using LetsMarket.DataBase;


namespace LetsMarket.Controller
{
    public static class ObjList
    {
        public static void ListClients()
        {
            Console.WriteLine("Listando Clientes");
            Console.WriteLine();

            var table = new Table(TableConfiguration.UnicodeAlt());
            table.From(Database.Clients);
            Console.WriteLine(table.ToString());
        }
        public static void ListEmployees()
        {
            Console.WriteLine("Listando Funcionários");
            Console.WriteLine();

            var table = new Table(TableConfiguration.UnicodeAlt());
            table.From(Database.Employees);
            Console.WriteLine(table.ToString());
        }
        public static void ListProducts()
        {
            Console.WriteLine("Listando Produtos");
            Console.WriteLine();

            var table = new Table(TableConfiguration.UnicodeAlt());
            table.From(Database.Products);
            Console.WriteLine(table.ToString());
        }
    }
}
