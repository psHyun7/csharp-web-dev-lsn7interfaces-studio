using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name) : base(name)
        {
            Storage = 4700;
            MinRPM = 570;
            MaxRPM = 1600;
        }

        public void ReadDisc()
        {
            Console.WriteLine("Simulate Reading Disc");
        }

        public void SpinDisc()
        {
            Console.WriteLine($"A DVD spins at a rate of {MinRPM} - {MaxRPM} rpm.");
        }

        public void WriteOnDisc()
        {
            Console.WriteLine("Simulate Writing on Disc");
        }
    }
}
