using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Trial
    {
        public static void DoJob()
        {

            try
            {
                int p = 10;
                int q = 0;
                int i = p / q;
            }
            catch (DivideByZeroException ex)
            {

                throw new DivideByZeroException(ex.Message);
                //MessageBox.Show("Cannot divide by 0");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //MessageBox.Show("Some other exception occured...");
            }
            //finally
            //{

                //MessageBox.Show("finally always fires whether exception occurs or not..");
            //}
        }
    }
}
