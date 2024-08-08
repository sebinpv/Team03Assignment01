using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    public class DeploymentTicket : Ticket
    {

        public override void CreateTicket()
        {
            Console.WriteLine($"Ticket {TId} for {SoftwareName} created.");
        }

        public override void UpdateTicket(string status)
        {
            Status = status;
            Console.WriteLine($"Ticket {TId} status updated to {Status}.");
        }

        public override void ViewTicket()
        {
            Console.WriteLine($"Ticket ID: {TId}");
            Console.WriteLine($"Software Name: {SoftwareName}");
            Console.WriteLine($"Request Type: {RequestType}");
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
