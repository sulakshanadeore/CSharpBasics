using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsApp
{

    [Serializable()]
 public   class Customer
    {


        public int Custid { get; set; }
        public string Custname { get; set; }
        
        [NonSerialized()]
        private string _cardno;
        private string CardNo
        {
            get { return _cardno; } 
            set { _cardno = value; } 
        }

        public int Amt { get; set; }
        public int Points { get; set; }
        public void CustomerPoints(int amt)
        {
            if (amt>1000 && amt<2000)
            {
                Points = 10;
            }
            else if(amt>2000 && amt<5000)
        {
                Points = 20;
            }
            else
            {
                Points = 5;
            }
        
        }

    }
}
