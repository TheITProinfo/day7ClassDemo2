using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7ClassDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tom = new Student("Tom",26,"male");
            //tom.Name = "Tom";
            //tom.Age = 26;
            //tom.Gender = "male";

            tom.SayHello();
            Student.Say2();

            Student jerry = new Student("Jerry",32,"male");
            //jerry.Name = "jerry";
            //jerry.Age = 32;
            //jerry.Gender = "spring";
            jerry.SayHello();

            Student alice = new Student("Alice","Female");
            //alice.Name = "Alice";
            //alice.Age = 25;
            //alice.Gender = "Female";
            alice.SayHello();

            Console.ReadLine();
        }
    }
}
