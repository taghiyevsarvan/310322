using System;
using System.Collections.Generic;
using System.Text;

namespace _310322
{
    
    internal class Student
    {

        private int _no;
        public string FullName { get; set; } 
        public int No { get; }

        public void ShowInfo()
        {
            Console.WriteLine("No: "+No+" - Full Name: "+FullName);
        }

        public Student()
        {
            _no++;
            No = _no;
        }
    }
}
