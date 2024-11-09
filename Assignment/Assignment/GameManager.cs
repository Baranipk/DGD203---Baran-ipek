using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    static public class GameManager
    {
       static public void StartGame()
        {
            Car car1 = new Car(1000f,100f,13000,new Engine(),"Red","Lightning");

            car1.OpenCarDoors();
            car1.StartCar();
            car1.engine.isWorking();
            car1.StopCar();
            car1.CloseCarDoors();

            Console.WriteLine("-------------------------------------------------------------------------" +
                "" +
                "");

            Engine engine1 = new Engine(205);
            Car car2 = new Car(800f, 120f, 15000,engine1, "Black", "toyota");

            Console.WriteLine($"Car name {car2.name} , car range {car2.range} , car color {car2.color}");

            car2.OpenCarDoors();
            car2.StartCar();
            car2.engine.isWorking();
            
            car2.StopCar();
            car2.CloseCarDoors();

            // Console.WriteLine(car2.engine.horsePower); does not work
            
            Console.WriteLine("-------------------------------------------------------------------------" +
                "" +
                "");

            Vehicle car4 = new Car(1000f, 100f, 13000, new Engine(), "Red", "Lightning");

            // car4.OpenCarDoors(); does not work

            car4.Open();
            car4.Close();           
            
        }
    }
}
