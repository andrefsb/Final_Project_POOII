using LetsMarket.DataBase;
using Sharprompt;


namespace LetsMarket.Controller
{
    public static class ObjEdit
    {
        public static void EditClient()
        {
            var client = Prompt.Select("Selecione o Cliente para Editar", Database.Clients, defaultValue: Database.Clients[0]);

            Prompt.Bind(client);

            Save.SaveClient();
        }
        public static void EditProduct()
        {
            var product = Prompt.Select("Selecione o Produto para Editar", Database.Products, defaultValue: Database.Products[0]);

            Prompt.Bind(product);

            Save.SaveProduct();
        }
        public static void EditEmployee()
        {
            var employee = Prompt.Select("Selecione o Funcionário para Editar", Database.Employees, defaultValue: Database.Employees[0]);

            Prompt.Bind(employee);

            Save.SaveEmployee();
        }
    }
}
