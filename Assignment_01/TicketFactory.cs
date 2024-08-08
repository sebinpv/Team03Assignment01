using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    public static class TicketFactory
    {
        public static Ticket CreateTicket(int tId, string softwareName, string requestType, int empId, DateTime date, string status)
        {
            return new DeploymentTicket
            {
                TId = tId,
                SoftwareName = softwareName,
                RequestType = requestType,
                EmpId = empId,
                Date = date,
                Status = status
            };
        }
    }
}
