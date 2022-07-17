using LetsMarket.Controller;


namespace LetsMarket.Menu
{
    internal class MenuInitialization
    {
        public static void InitializeMenu()
        {
            var menu = new MenuItem("Menu Principal");

            var products = new MenuItem("Produtos");
            products.Add(new MenuItem("Cadastrar Produto", ObjAdd.AddProduct));
            products.Add(new MenuItem("Listar Produtos", ObjList.ListProducts));
            products.Add(new MenuItem("Editar Produto", ObjEdit.EditProduct));
            products.Add(new MenuItem("Remover Produto", ObjRemove.RemoveProduct));

            var employees = new MenuItem("Funcionários");
            employees.Add(new MenuItem("Cadastrar Funcionário", ObjAdd.AddEmployee));
            employees.Add(new MenuItem("Listar Funcionários", ObjList.ListEmployees));
            employees.Add(new MenuItem("Editar Funcionário", ObjEdit.EditEmployee));
            employees.Add(new MenuItem("Remover Funcionário", ObjRemove.RemoveEmployee));

            var clients = new MenuItem("Clientes");
            clients.Add(new MenuItem("Cadastrar Cliente", ObjAdd.AddClient));
            clients.Add(new MenuItem("Listar Clientes", ObjList.ListClients));
            clients.Add(new MenuItem("Editar Cliente", ObjEdit.EditClient));
            clients.Add(new MenuItem("Remover Cliente", ObjRemove.RemoveClient));

            var sales = new MenuItem("Vendas");
            sales.Add(new MenuItem("Efetuar Venda", Sale.MakeSale));

            menu.Add(products);
            menu.Add(employees);
            menu.Add(clients);
            menu.Add(sales);
            menu.Add(new MenuItem("Sair", () => Environment.Exit(0)));

            menu.Execute();
        }
    }
}
