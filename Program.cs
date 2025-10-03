using System;
using System.Collections.Generic;
using Kodanalys.Models; //User-klassen importeras, the user-class is imported

namespace Kodanalys
{
    class Program
    {
        static List<User> users = new List<User>(); //hänvisar till user-klassen, refers to user-class
        static void Main(string[] args)
        {
            bool programMain = true;

            while (programMain)
            {
                ShowMenu(); //Visar menyn för användaren, Show the menu for the user
                string choise = Console.ReadLine();
                Console.WriteLine();

                switch (choise) //5 olika cases o ett Ogiltigt val, 5 diffrent cases and a little error
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        ListUser();
                        break;
                    case "3":
                        RemoveUser();
                        break;
                    case "4":
                        SearchUser();
                        break;
                    case "5":
                        programMain = false;
                        Console.WriteLine("Programmet avslutas...");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val");
                        break;
                }
            }
        }
        static void ShowMenu() //Menyval, Menuchoice
        {
            Console.WriteLine("\nVälj ett alternativ:");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Visa alla användare");
            Console.WriteLine("3. Ta bort användare");
            Console.WriteLine("4. Sök användare");
            Console.WriteLine("5. Avsluta");
            Console.Write("Ditt val: "); //La till texten istället för tomt fält, added text instead of emty fields
        }
        static void AddUser() //Lägger till användare, Add Users
        {
            Console.Write("Ange namn: ");
            string userName = Console.ReadLine();

            var newUser = new User { Name = userName }; //skapar ett User-objekt, creates a user-object
            users.Add(newUser);

            Console.WriteLine("Användare tillagd");
        }
        static void ListUser() //listar användare, lists user
        {
            Console.WriteLine("Användare:");
            if (users.Count == 0)
            {
                Console.WriteLine("Ingen användare tillagd.");
            }
            else
            {
                foreach (var user in users)
                {
                    Console.WriteLine(user.Name); //använder egenskapen från User-klassen
                }
            }
        }



