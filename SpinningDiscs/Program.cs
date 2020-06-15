using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD Cd1 = new CD("First CD");
            DVD Dvd1 = new DVD("First DVD");
            // TODO: Call each CD and DVD method to verify that they work as expected.
            Cd1.SpinDisc();
            Dvd1.SpinDisc();

            Console.WriteLine("\n" + Cd1.ToString());
            Console.WriteLine(Dvd1.ToString());
        }
    }
}
