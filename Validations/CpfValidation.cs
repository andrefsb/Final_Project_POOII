using LetsMarket.DataBase;
using Sharprompt;

namespace LetsMarket.Validations
{
    public class CpfValidation
    {
        public static void ValidateCpf()
        {
            var cpf = Prompt.Input<string>("Digite o documento para identificar o cliente ou [ENTER] para continuar");
            if (!string.IsNullOrEmpty(cpf))
            {
                var clientName = "";
                foreach (var client in Database.Clients)
                {
                    if (client.Cpf == cpf)
                        clientName = client.Name;
                }
                if (!string.IsNullOrEmpty(clientName))
                    Console.WriteLine($"{clientName}");
            }
        }

    }
}
