using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - done
            //The methods should take one string parameter: the respective noise property - done           

            //Now that the Car class is created we can instanciate 3 new cars - done
            //Set the properties for each of the cars - done
            //Call each of the methods for each car - done


            var myCar = new Car();

            // Version 1: DOT NOTATION
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2014;
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "honk";
            myCar.IsDriveable = true;


            var parkersCar = new Car()
            {
                //Version 2: OBJECT INITIALIZER SYNTAX
                Make = "Mazda",
                Model = "3",
                Year = 2014,
                EngineNoise = "vroom vroom",
                HonkNoise = "beep",
                IsDriveable = true
            };

            //Version 3: (USING THE CONSTRUCTOR TO ALLOW PARAMETER VALUES TO BE PLACED INSIDE PROPERTIES)
            var dollysCar = new Car("Mustang", "Viper", 2019, "VRROOM", "HONK", true);


            //calling the methods
            parkersCar.MakeEngineNoise($"Parker's car goes {parkersCar.EngineNoise},");

            dollysCar.MakeEngineNoise($"Dolly's car goes {dollysCar.EngineNoise}.");

            parkersCar.MakeHonkNoise(parkersCar.HonkNoise);

            dollysCar.MakeHonkNoise(dollysCar.HonkNoise);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
