using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsdeneme2
{
    public class ClassCars
    {
        public int carDoor;
        public string carModel;
        public string carColour;

        public void carStart()
        {
            Console.WriteLine("Car is starting");
        }

        public void carDoorClose() // Constructor Method
        {
            Console.WriteLine("Car's door is closing");
        }

        public ClassCars(int carDoor3, string carModel3, string carColour3) // Consructor Method
        {
            carDoor = carDoor3;
            carModel = carModel3;
            carColour= carColour3;
        }

    }
}
