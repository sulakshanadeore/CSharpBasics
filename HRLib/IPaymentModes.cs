using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    interface IPaymentModes
    {
        bool PayByBHIMUPI(long UPIid, double Amt, int UPIPin, int OTP);
        bool PayNetBanking(double Amt, int OTP, string CustomerPassword, string BankName);
        bool PaybyCard(long CardNo, DateTime ExpDate, int CVV, string BankName, double Amt, int OTP);
        bool PayCOD();
        bool PayByPaytm(long PaytmAcno, int PIN, double amt);
        bool PayByGpay(long Acno, int PIN, double Amt, string loginid);
        bool PayByQRCode(long UPIPin, double Amt);

    }

    public class ShopKeeper : IPaymentModes
    {
        public bool PayByBHIMUPI(long UPIid, double Amt, int UPIPin, int OTP)
        {
            throw new NotImplementedException();
        }

        public bool PaybyCard(long CardNo, DateTime ExpDate, int CVV, string BankName, double Amt, int OTP)
        {
            bool status;
            if (Amt < 200)
            {
                Console.WriteLine("Not availble");
                status = false;
            }
            else
            {
                Console.WriteLine("Ok");
                status = true;
            }
            return status;
        }

        public bool PayByGpay(long Acno, int PIN, double Amt, string loginid)
        {
            throw new NotImplementedException();
        }

        public bool PayByPaytm(long PaytmAcno, int PIN, double amt)
        {
            throw new NotImplementedException();
        }

        public bool PayByQRCode(long UPIPin, double Amt)
        {
            throw new NotImplementedException();
        }

        public bool PayCOD()
        {
            throw new NotImplementedException();
        }

        public bool PayNetBanking(double Amt, int OTP, string CustomerPassword, string BankName)
        {
            throw new NotImplementedException();
        }
    }


    public class IRCTCBooking : IPaymentModes
    {
        public bool PayByBHIMUPI(long UPIid, double Amt, int UPIPin, int OTP)
        {
            //throw new NotImplementedException();
            return true;
        }

        public bool PaybyCard(long CardNo, DateTime ExpDate, int CVV, string BankName, double Amt, int OTP)
        {
            //throw new NotImplementedException();
            return true;
        }

        public bool PayByGpay(long Acno, int PIN, double Amt, string loginid)
        {
            //throw new NotImplementedException();
            return true;
        }

        public bool PayByPaytm(long PaytmAcno, int PIN, double amt)
        {
            //throw new NotImplementedException();
            return true;
        }

        public bool PayByQRCode(long UPIPin, double Amt)
        {
            //throw new NotImplementedException();
            return true;
        }

        public bool PayCOD()
        {
            Console.WriteLine("this facility is not available");
            return false;
            
        }

        public bool PayNetBanking(double Amt, int OTP, string CustomerPassword, string BankName)
        {
            //throw new NotImplementedException();
            return true;
        }
    }


}
