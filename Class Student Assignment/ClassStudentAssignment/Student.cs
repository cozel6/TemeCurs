using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudentAssignment
{
    internal class Student
    {
        //Fields
        private int _age;
        private string _name;

        //Constants
        public const int MIN_AGE = 18;
        public const int MAX_AGE = 99;

        // Properties
        public int Age
        {
            get { return _age; }
            set
            {
                if(value <  MIN_AGE || value > MAX_AGE)
                {
                    Console.WriteLine($"Incorect value, min is {MIN_AGE} and max is {MAX_AGE},please enter the right value");
                    return;
                }
                _age = value;
            }
        }
        public int? Mark {  get; set; }

        //Constructor
        public Student(int age, string name)
        {
            Age = age;
            _name = name;
        }

        //ReadOnly Propery
        public string Info
        {
            get
            {
                return $"{_name}, {Age}";
            }
        }
    }
}
