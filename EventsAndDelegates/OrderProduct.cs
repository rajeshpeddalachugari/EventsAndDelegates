using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    
  public  class OrderProduct
    {
        public EventHandler<customEventArgs> orderPlacedEvent;
        public int OrderID { get; set; }
        public void PlaceOrder(string name,ulong mobile,string email)
        {
            Customer customerObj = new Customer();
            customerObj.Mobile = mobile;
            customerObj.EMail = email;
            customerObj.Name = name;
            Random rnd = new Random();
            OrderID = rnd.Next(10000);
            OnOrderPlaced(OrderID,customerObj);
        }
        public virtual void OnOrderPlaced(int ordernum,Customer customerObj)
        {
            if (orderPlacedEvent != null)
            {
                this.orderPlacedEvent(this, new customEventArgs()
                {
                    Customer = customerObj,OrderId=ordernum
                });
            }
        }
    }
}
