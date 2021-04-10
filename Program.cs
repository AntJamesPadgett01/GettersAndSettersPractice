using System;

namespace GettersAndSettersPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie boost = new Movie("Boost","Koko", "DOG");
            Movie hoops = new Movie( "Hoops","Tony", "PG");
            //G,PG,PG-13,R,NR

            Console.WriteLine(boost.Rating);// set to private in movie class

        }
    }
}
