using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
   public enum PaymentMode
    {
        BhimUPi,
        NetBanking,
        CardPayment,
        Paytm,
        COD,
        Gpay,
        QR

    }
public class CustomerPayment
    {
        public bool PaymentReceived { get; set; }
     
        public void Pay(long UPIid, double Amt, int UPIPin, int OTP)
        {
            PaymentReceived = true;
        }
        public void Pay(double Amt, int OTP, string CustomerPassword, string BankName)
        {
            PaymentReceived = true;

        }

        public void Pay(long CardNo, DateTime ExpDate, int CVV,string  BankName, double Amt,int OTP)
        {
            PaymentReceived = true;
        }

        public void Pay()
        {
            PaymentReceived = true;


        }

        public void Pay(long PaytmAcno,int PIN,double amt)
        {

            PaymentReceived = true;
        }

        public virtual void Pay(long Acno, int PIN, double Amt, string loginid)
        {
            PaymentReceived = true;
        }

        public void Pay(long UPIPin,double Amt)
        {
            PaymentReceived = true;
        }

        public void CustomerDetails()
        {
            ShowDetails();
        }
        private void ShowDetails()
        {
        
        }



    }
}
