using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Car : Vehicle
    {
        public string name = "null";
        public string color = "white";

        

        public IEngine engine;
        public Car(float _range,float _maxSpeed,int _cost,IEngine _engine)
        {
            range = _range;
            maxSpeed = _maxSpeed;
            cost = _cost;
            engine = _engine;   
        }
        public Car(float _range, float _maxSpeed, int _cost, IEngine _engine, string _color, string _name)
        {
            range = _range;
            maxSpeed = _maxSpeed;
            cost = _cost;
            engine = _engine;
            name = _name;
            color = _color;
        }
        public void OpenCarDoors()
        {
            base.Open();
        }

        public void CloseCarDoors() 
        {
            base.Close();
        }

        public void StartCar()
        {
            engine.StartEngine();
        }

        public void StopCar() 
        {
            engine.StopEngine(); 
        }


    }
}
