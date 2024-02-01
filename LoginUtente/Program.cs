using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUtente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Continua = "";
            do
            {
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Verifica ora e data di login");
                Console.WriteLine("4. Lista accessi");
                Console.WriteLine("5. Esci");
                int scelta = Convert.ToInt16(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Utente.Login();
                        Console.WriteLine("Vuoi continuare? (y/n)");
                        Continua = Console.ReadLine();
                        break;
                    case 2:
                        Utente.Logout();
                        Console.WriteLine("Vuoi continuare? (y/n)");
                        Continua = Console.ReadLine();
                        break;
                    case 3:
                        Utente.StampaAccesso();
                        Console.WriteLine("Vuoi continuare? (y/n)");
                        Continua = Console.ReadLine();
                        break;
                    case 4:
                        Utente.StoricoUtenti();
                        Console.WriteLine("Vuoi continuare? (y/n)");
                        Continua = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Chiusura del programma in corso...");
                        Continua = "n";
                        break;
                    default:
                        Console.WriteLine("Scelta non prevista...");
                        Console.WriteLine("Vuoi continuare? (y/n)");
                        Continua = Console.ReadLine();
                        break;

                }
            }
            while (Continua == "y");
                Console.ReadLine();

            
        }
        
    }
}
