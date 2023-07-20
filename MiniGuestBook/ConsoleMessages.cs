using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MiniGuestBook
{
    public class ConsoleMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Mini Guest Book Application");
            Console.WriteLine("The application is still being developed");
            Console.WriteLine("----------------------------------------");
        }

        public static string GetPartyName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();
            
            return output;
        }

        public static int GetPartySize()
        {
            bool isValidNumber;
            int output;
            do {
                Console.Write("How many guest are there in your party? ");
                string amountText = Console.ReadLine();
                isValidNumber = int.TryParse(amountText, out output);
                if(!isValidNumber)
                {
                    Console.WriteLine("The number you provided is not valid. Please try again!");
                }
            } while(isValidNumber == false);
            return output;
        }
        public static bool AskToContinue()
        {
            Console.Write("Is there more guess coming? (yes/no) : ");
            string continueLooping = Console.ReadLine();
            bool output = (continueLooping.ToLower() == "yes");
            return output;
        }
        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;
            List<string> guestList = new();

            do{
            guestList.Add(GetPartyName()) ;
            totalGuests += GetPartySize();
            }while(AskToContinue());
            return (guestList, totalGuests);
        }
        public static void DisplayGuestList(List<string> list)
        {
            Console.WriteLine("The guests list are:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
