using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LoginUtente
{
    public static class Utente
    {
        public static string username;
        public static string password;
        public static bool isLogged;
        public static DateTime DataOraLog;
        public static List<string> AccessiUtenti = new List<string>(); 

        public static void Login()
        {
            Console.WriteLine("Inserire username:");
            Utente.username = Console.ReadLine();
            Console.WriteLine("Inserire password:");
            Utente.password = Console.ReadLine();
            Console.WriteLine("Inserire conferma password:");
            string conferma = Console.ReadLine();

            if (conferma == Utente.password && Utente.username != "")
            {
                Utente.isLogged = true;
                Utente.DataOraLog = DateTime.Now;
                Utente.AccessiUtenti.Add(Utente.username);
                Console.WriteLine("Utente loggato correttamente");
                
            }
            else
            {
                Console.WriteLine("Errore nella compilazione dei campi");
            }

        }

        public static void Logout()
        {
            Utente.username = "";
            Utente.password = "";
            Utente.isLogged = false;
            Console.WriteLine("Nessun utente loggato");
        }
        public static void StoricoUtenti()
        {
            foreach (var record in Utente.AccessiUtenti)
            {
                Console.WriteLine($" {record} \n ");
            }
        }

        public static void StampaAccesso()
        {
            if(Utente.isLogged == true)
            {
                Console.WriteLine($"Orario accesso: {Utente.DataOraLog}");
            }
            else
            {
                Console.WriteLine("Necessario effettuare il login"); 
            }
        }


    }

    


    
}
