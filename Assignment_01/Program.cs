using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = null;

            while (true)
            {
                TicketService.DisplayMenu();
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                TicketService.HandleMenuChoice(choice, ref ticket);

                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
