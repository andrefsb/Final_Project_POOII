using LetsMarket.DataBase;
using LetsMarket.Entities;
using Sharprompt;

namespace LetsMarket.Controller
{
    internal class ObjAdd : Database
    {
        public static void AddProduct()
        {
            var product = Prompt.Bind<Product>();

            if (!Prompt.Confirm("Deseja Salvar?"))
                return;

            Products.Add(product);
            Save.SaveProduct();
        }
        public static void AddEmployee()
        {
            var employee = Prompt.Bind<Employee>();
            if (!Prompt.Confirm("Deseja Salvar?"))
                return;

            Employees.Add(employee);

            if (Employees.Count > 1 && Employees[0].Login == "admin" && Employees[0].Password == "admin")
            {
                Employees.Remove(Employees[0]);

            }
            Save.SaveEmployee();
        }
        public static void AddClient()
        {
            var employee = Prompt.Bind<Client>();

            if (!Prompt.Confirm("Deseja Salvar?"))
                return;

            Clients.Add(employee);
            Save.SaveClient();
        }

    }
}
