using System.Net.Cache;

namespace DogValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //negative case 1 : age < 0
            try
            {
                DogError dogError = new DogError
                {
                    Age = -5,  
                    Name = "Rex"
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            // negative case 2 : age > 100
            try
            {
                DogError dogError2 = new DogError
                {
                    Age = 101,  
                    Name = "Rex"
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            //negative case 3 : name < 2 ch
            try
            {
                DogError dogError = new DogError
                {
                    Age = 5,  
                    Name = "R" // trigger 
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            // positive obj
            try
            {
                DogError dogError = new DogError
                {
                    Age = 15,
                    Name = "Rex"  
                };
                if( dogError.Age == 1) // in cazul in care cainele are varsta de 1 an :D
                {
                    Console.WriteLine($"Cainele are varsta de: {dogError.Age} an si numele de: {dogError.Name}");
                }
                else
                {
                    Console.WriteLine($"Cainele are varsta de: {dogError.Age} ani si numele de: {dogError.Name}");
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
