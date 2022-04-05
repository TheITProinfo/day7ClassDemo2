using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7ClassDemo2
{
      class Student
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }

        private string _gender;

        public string Gender
        {
           set { _gender=value;}
            get { return _gender; }
          }

        public void SayHello()
        {
            Console.WriteLine("I am {0}, {1}years old, {2}",this.Name,this.Age,this.Gender);
        }

        public static void Say2()
        {
            Console.WriteLine("this is static method");
        }
        
        public Student(string name,int age, string gender) // constructor method
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public  Student(string name,string gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        public Student()
        { 
        }
    
    }
}
