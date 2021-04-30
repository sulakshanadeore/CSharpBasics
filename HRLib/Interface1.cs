using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    interface IAdmission
    {
         int Marks { get; set; }
        void Cutoff1();
        void Cutoff2();
        

    }

    interface ITeachers
    {
        void AssignSubject(string teachername);
    }


    public class StudAdmission : Student,IAdmission,ITeachers
    {

        public void OwnMethod()
        { 
        
        }
        int _marks;
        public int Marks
        {
            get
            {
                return _marks;
            }
            set
            {

                if (_marks<0)
                {
                    Console.WriteLine("Etner valid marks");
                }

            }

        }

        public void AssignSubject(string teachername)
        {
            //throw new NotImplementedException();
        }

        public void Cutoff1()
        {
            throw new NotImplementedException();
        }

        public void Cutoff2()
        {
            throw new NotImplementedException();
        }
    }

    class Admission : IAdmission
    {

        int _marks;
        public int Marks
        {
            get
            {
                return _marks;
            }
            set 
            {
                _marks = value; 
            }
        
        }

        public void Cutoff1()
        {
            throw new NotImplementedException();
        }

        public void Cutoff2()
        {
            throw new NotImplementedException();
        }
    }




}
