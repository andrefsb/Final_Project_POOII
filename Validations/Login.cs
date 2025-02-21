﻿using LetsMarket.DataBase;
using LetsMarket.Menu;


namespace LetsMarket.Validations
{
    public static class Login
    {
        public static void VerifyLogin()
        {
            var loggedIn = false;
            var attempts = 0;

            do
            {
                attempts++;
                Console.Clear();

                if (attempts > 1)
                {
                    Console.WriteLine(Environment.NewLine);
                    ConsoleInput.WriteError("DADOS INCORRETOS");
                    Console.WriteLine(Environment.NewLine);
                }

                Console.WriteLine("SYSTEM LOGIN");

                var username = ConsoleInput.GetString("login");
                var password = ConsoleInput.GetPassword("senha");

                foreach (var usuario in Database.Employees)
                {
                    if (usuario.Login == username && usuario.Password == password)
                        loggedIn = true;
                }

            } while (!loggedIn);

        }
    }
}
