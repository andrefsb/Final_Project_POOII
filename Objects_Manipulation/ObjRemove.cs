using LetsMarket.DataBase;
using LetsMarket.Menu;
using Sharprompt;


namespace LetsMarket.Controller
{
    internal class ObjRemove : Database
    {
        public static void RemoveProduct()
        {
            var product = Prompt.Select("Selecione o Produto para Remover", Products);
            var confirm = Prompt.Confirm("Tem Certeza?", false);

            if (!confirm)
                return;

            Products.Remove(product);
            Save.SaveProduct();
        }

        public static void RemoveEmployee()
        {
            if (Employees.Count == 1)
            {
                ConsoleInput.WriteError("Não é possível remover todos os usuários.");
                Console.ReadKey();
                return;
            }

            var employee = Prompt.Select("Selecione o Funcionário para Remover", Employees);
            var confirm = Prompt.Confirm("Tem Certeza?", false);

            if (!confirm)
                return;

            Employees.Remove(employee);
            Save.SaveEmployee();
        }

        public static void RemoveClient()
        {
            if (Clients.Count == 1)
            {
                ConsoleInput.WriteError("Não é possível remover todos os usuários.");
                Console.ReadKey();
                return;
            }

            var client = Prompt.Select("Selecione o Cliente para Remover", Clients);
            var confirm = Prompt.Confirm("Tem Certeza?", false);

            if (!confirm)
                return;

            Clients.Remove(client);
            Save.SaveClient();
        }
    }
}
