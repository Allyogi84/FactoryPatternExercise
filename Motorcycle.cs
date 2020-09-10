using System;
namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The Motorcycle is revving up! Wooo! ");
            Console.WriteLine("Vroooooooooom");
        }



    }
}
