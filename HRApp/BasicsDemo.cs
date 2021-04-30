using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp
{
    class BasicsDemo
    {
        static void Main(string[] args)
        {
            int i = 100;
            double j = 3444.34d;
            //ConsoleColor--- enum---
            string name = "Ash";


            //j = i;-- assigning value of i to j
            //name = i.ToString();// convertiung i to string

            object o;
            o = i;//Boxing
            //i will become of what type---- object

            Type ostype=o.GetType();
            Console.WriteLine(ostype);

            int t;
            t =(int) o;//cast to  my type int ----- Unboxing

            int value = 100;
            object o1;
            o1 = value;//Boxing
            int oldvalue;
            oldvalue = (int)o1;//Unboxing
            object o2=oldvalue;//Boxing
            object o3 = o2;//Assignment



            //Reference types can be assigned  null but value types cannot be assigned null.
            //int p1 = null;// Cannot assign null to a value type---
            // Null--able---> able to hold null value
            int? p1 = null;
            Nullable<int> p2 = null;
            string fname = null;

            







            //class,delegate,event,interface etc----- Reference Types
            //struct & enums---- Value types
            //valuetypes are stored on the stack and 
            //Reference types are stored on the heap


            //Boxing- Only value types can be boxed
            //object class --ToString()virtual--- override

            //Every type inherits from  object
            //Object is the parent of all types
            //int --Child:Parent
            //int-- override ToString()

            

            
            

        }
    }
}
