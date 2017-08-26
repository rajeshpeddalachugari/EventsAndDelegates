using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProduct ob = new OrderProduct();
            ob.orderPlacedEvent += NotifyCustomerViaEmail;
            ob.orderPlacedEvent += NotifyCustomerViaSMS;
            ob.orderPlacedEvent += InformCourierService;
            ob.PlaceOrder("Rajesh",9866884449,"rajesh@outlook.com");
         }

        private static void NotifyCustomerViaEmail(object obj, customEventArgs args)
        {
            Console.WriteLine("-----------------------------E-Mail-------------------------------");
            Console.WriteLine("Email received on {0}", args.Customer.EMail);
            Console.WriteLine("Hey {0} your order is placed successfully with order ID :  {1}", args.Customer.Name, args.OrderId);
            Console.WriteLine("-----------------------------------------------------------------");
        }

        private static void NotifyCustomerViaSMS(object sender, customEventArgs args)
        {
            Console.WriteLine("----------------------------SMS-------------------------------");
            Console.WriteLine("SMS received on {0}", args.Customer.Mobile);
            Console.WriteLine("Hey {0} your order is placed successfully with order ID :  {1}", args.Customer.Name, args.OrderId);
            Console.WriteLine("-----------------------------------------------------------------");
        }

        private static void InformCourierService(object sender, customEventArgs args)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Hey Partner please initiate the delivery with the following details");
            Console.WriteLine("Order id :{0}",args.OrderId);
            Console.WriteLine("Name :{0}", args.Customer.Name);
            Console.WriteLine("Mobile :{0}", args.Customer.Mobile);
            Console.WriteLine("Email :{0}", args.Customer.EMail);
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
 
}
