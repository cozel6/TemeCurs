using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogValidation
{
    public class DogError
    {

        private int age;
        private string name;


        public int Age
        {
            get 
            {
                return age; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Varsta nu poate avea valoare negaiva");
                }
                if (value > 100)
                {
                    throw new ArgumentException("Varsta nu poate avea valoarea peste 100");
                }
                age = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Numele nu poate contine mai putin de 2 caractere");
                }
                name = value;
            }
        }
        
        public DogError() {}

        public DogError(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
