using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    public interface ITicket
    {
        void CreateTicket();
        void UpdateTicket(string status);
        void ViewTicket();
    }
}
