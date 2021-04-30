using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    interface IInterface
    {

    }



  public  class Student:CustomerPayment
    {
        //public new void Pay(long Acno, int PIN, double Amt, string loginid)
        //{
        //    //not using base class functionality
        //    //own functionality
        //    Console.WriteLine("Enter stud no");
        //    Console.WriteLine("Enter class");
        //    Console.WriteLine("Enter loc");

        //}

        public void StudentDetails()
        {
            base.CustomerDetails();
        
        }

        //base class- CustomerPayment--- Pay--Student --- Pay----override
        public override void Pay(long Acno, int PIN, double Amt, string loginid)
        {
            //Use the base class functionality + extra functionality
            base.Pay();
            Console.WriteLine("Sending SMS as a confirmation");
        }

        //public void SendSMS()
        //{ 
        
        //}
        public void StudentPays()
        {
            //CustomerPayment c = new CustomerPayment();
            //c.
            double Amt=3324;
            int OTP=34;
            string pwd="23", bankname="ABC";

            base.Pay(Amt, OTP, pwd, bankname);
        }
        
    }
}
