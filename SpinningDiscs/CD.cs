using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(string name) : base(name)
        {
            Storage = 700;
            MinRPM = 200;
            MaxRPM = 500;
        }

        public void ReadDisc()
        {
            Console.WriteLine("Simulate Reading Compact Disc");
        }

        public void SpinDisc()
        {
            Console.WriteLine($"A CD spins at a rate of {MinRPM} - {MaxRPM} rpm.");
        }

        public void WriteOnDisc()
        {
            Console.WriteLine("Simulate Writing on Disc");
        }
    }
}
