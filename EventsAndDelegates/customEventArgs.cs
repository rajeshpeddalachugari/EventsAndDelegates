using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
   public class customEventArgs : EventArgs
    {
        public Customer Customer { get; set; }
        public int OrderId { get; set; }
    }
}
