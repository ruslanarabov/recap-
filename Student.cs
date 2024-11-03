using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap
{
    public class Student : Human
    {
        public Student (string name, byte age) : base(name,age)
        {

        }
        public Student (string name, byte age, double grant) : this(name,age)
        {
            this.Grant =grant;
        }
        public double Grant;

        public void ShowFullData()
        {
            System.Console.WriteLine($"{Name} {Age} {Grant}");
        }
    }
}