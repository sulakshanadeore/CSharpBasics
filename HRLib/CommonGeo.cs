using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
   public abstract class CommonGeo:IAdmission
    {

       public const float pi = 3.14f;

        public int Marks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Cutoff1()
        {
            throw new NotImplementedException();
        }

        public void Cutoff2()
        {
            throw new NotImplementedException();
        }

        public void M1()
        {
            Console.WriteLine("HEllo");
        }

    public abstract void M2();
    }

    //public class C1:Geometry{}

    public class C3 : C2 {

        public sealed override void M2()
        {
            Console.WriteLine("Overriden");
        
        }


    }

  public  class A
    {
        public void M1() { }
        public virtual void M2() { }
    }
    public class B : A
    {
        public new void M1()
        {
        }
        //public sealed override void M2() { }

        //public abstract  void M2();




    }


    public abstract class A2
    {
        public void A2M1()
        { 
        
        
        }
    
    }
    class C : B 
    {
        public new void M1()
        {
        }
      //  public override void M2() { }

    }



    public class C4 : C3
    {
        //public override void M2()
        //{ 
        
        
        //}


    }

    public class C2 : CommonGeo, IPaymentModes
    {
        public override void M2()
        {
            //       throw new NotImplementedException();
            Console.WriteLine("Implemented...");

        }

        public bool PayByBHIMUPI(long UPIid, double Amt, int UPIPin, int OTP)
        {
            throw new NotImplementedException();
        }

        public bool PaybyCard(long CardNo, DateTime ExpDate, int CVV, string BankName, double Amt, int OTP)
        {
            throw new NotImplementedException();
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

    public sealed class Geometry : CommonGeo,IPaymentModes
    {
        public override void M2()
        {
            Console.WriteLine("Bye");
            base.M1();

        }
        public void CalculateArea(int r)
        {
            Console.WriteLine(CommonGeo.pi * r * r);
        }

        public bool PayByBHIMUPI(long UPIid, double Amt, int UPIPin, int OTP)
        {
            throw new NotImplementedException();
        }

        public bool PayNetBanking(double Amt, int OTP, string CustomerPassword, string BankName)
        {
            throw new NotImplementedException();
        }

        public bool PaybyCard(long CardNo, DateTime ExpDate, int CVV, string BankName, double Amt, int OTP)
        {
            throw new NotImplementedException();
        }

        public bool PayCOD()
        {
            throw new NotImplementedException();
        }

        public bool PayByPaytm(long PaytmAcno, int PIN, double amt)
        {
            throw new NotImplementedException();
        }

        public bool PayByGpay(long Acno, int PIN, double Amt, string loginid)
        {
            throw new NotImplementedException();
        }

        public bool PayByQRCode(long UPIPin, double Amt)
        {
            throw new NotImplementedException();
        }
    }
}
