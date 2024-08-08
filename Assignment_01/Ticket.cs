using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    public abstract class Ticket : ITicket
    {
        private int tId;
        private string softwareName;
        private string requestType;
        private int empId;
        private DateTime date;
        private string status;

        public int TId
        {
            get { return tId; }
            set { tId = value; }
        }

        public string SoftwareName
        {
            get { return softwareName; }
            set { softwareName = value; }
        }

        public string RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public abstract void CreateTicket();
        public abstract void UpdateTicket(string status);
        public abstract void ViewTicket();
    }
}
