using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_project1
{
    public class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;
        public Car(string colorName, string nameName, int maxSpeedValue, int yearValue)
        {
            name= nameName;
            maxSpeed = maxSpeedValue;
            year = yearValue;
            color= colorName;

        }
        public Car(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + "is going at the speed of " + maxSpeed);
        }
        

    }
}
