using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace HRApp
{
    class MultipleInheritanceDemo
    {
        static void Main(string[] args)
        {
            //StudAdmission admission = new StudAdmission();
            //admission.Marks = 70;
            //admission.AssignSubject("Maths");
            //admission.Amt = 1000d;
            //admission.OwnMethod();

            IRCTCBooking booking = new IRCTCBooking();
            bool status = booking.PaybyCard(234324, new DateTime(2020, 3, 3),344,"HRDF",2333d,333);
            if (!status)
            {
                Console.WriteLine("Booking failed!!");
            }
            else
            {
                Console.WriteLine("Booking successful!!!");
            }
            Console.WriteLine("-------------Shopkeeper continues--------------");
            ShopKeeper shop = new ShopKeeper();
            status=shop.PaybyCard(234324, new DateTime(2020, 3, 3), 344, "HRDF", 100d, 333);
            if (!status)
            {
                Console.WriteLine("Booking failed!!");
            }
            else
            {
                Console.WriteLine("Booking successful!!!");
            }
            Console.Read();
        }
    }
}
