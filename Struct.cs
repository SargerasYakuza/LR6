using System;
using System.Collections.Generic;
using System.Text;

namespace LR6
{
    struct Student
    {
        public string Name;
        public int Age;
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void info()
        {
            Console.WriteLine(Name + " " + Age);
        }
    }
}
