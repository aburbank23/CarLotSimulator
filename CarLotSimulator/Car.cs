using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }

        //make another constructor in order to make the third way (momsCar) in program.cs
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine($"This car {EngineNoise}s.");
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }


    }
}
