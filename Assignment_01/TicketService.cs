using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    public static class TicketService
    {
        private static List<Ticket> tickets = new List<Ticket>();
        public static Ticket InputTicketDetails()
        {
            Random random = new Random();
            int tId = random.Next(1,100);

            Console.Write("Enter Software Name: ");
            string softwareName = Console.ReadLine();

            Console.Write("Enter Request Type: ");
            string requestType = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int empId = int.Parse(Console.ReadLine());

            Console.Write("Enter Status: ");
            string status = Console.ReadLine();

            DateTime date = DateTime.Now;

            Ticket ticket = TicketFactory.CreateTicket(tId, softwareName, requestType, empId, date, status);
            tickets.Add(ticket);
            return ticket;
        }

        public static void UpdateTicketStatus(Ticket ticket)
        {
            Console.Write("Enter new status: ");
            string status = Console.ReadLine();
            ticket.UpdateTicket(status);
        }

        public static void ViewTicket(Ticket ticket)
        {
            ticket.ViewTicket();
        }

        public static void ViewTicketById()
        {
            Console.Write("Enter Ticket ID to view: ");
            int tId = int.Parse(Console.ReadLine());

            Ticket ticket = tickets.FirstOrDefault(t => t.TId == tId);
            if (ticket != null)
            {
                ticket.ViewTicket();
            }
            else
            {
                Console.WriteLine("Ticket not found.");
            }
        }

        public static void ViewAllTickets()
        {
            if (tickets.Count == 0)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            Console.WriteLine("All Tickets:");
            foreach (var ticket in tickets)
            {
                ticket.ViewTicket();
                Console.WriteLine();
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create Ticket");
            Console.WriteLine("2. Update Ticket Status");
            Console.WriteLine("3. View Ticket");
            Console.WriteLine("4. View All Ticket");
            Console.WriteLine("5. Exit");
        }

        public static void HandleMenuChoice(int choice, ref Ticket ticket)
        {
            switch (choice)
            {
                case 1:
                    ticket = InputTicketDetails();
                    ticket.CreateTicket();
                    break;
                case 2:
                    if (ticket != null)
                    {
                        UpdateTicketStatus(ticket);
                    }
                    else
                    {
                        Console.WriteLine("No ticket found. Create a ticket first.");
                    }
                    break;
                case 3:
                    if (tickets.Any())
                    {
                        ViewTicketById();
                    }
                    else
                    {
                        Console.WriteLine("No ticket found. Create a ticket first.");
                    }
                    break;
                case 4:
                    ViewAllTickets();
                    break;
                case 5:
                    Console.WriteLine("Exiting the system...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

}
