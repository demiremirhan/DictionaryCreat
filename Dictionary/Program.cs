using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int,string> Student =new Dictionary <int, string> ();

            Student.Add(141, "nos");
            Student.Add(164, "asa");

            Console.WriteLine(Student.Count);

            MyDictionary<int, string> Student2 = new MyDictionary<int, string>();

            Student2.Add(16431, "aav");
            Student2.Add(1963,"ascv");
            Student2.Add(16613,"avsbbfb");

            Console.WriteLine(Student2.Count);


        }
    }
}
