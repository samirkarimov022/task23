﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23._1.Moduls
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
