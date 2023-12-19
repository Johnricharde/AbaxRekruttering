using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    public class Car : Vehicle
    {
        string Color;
        int MaxSpeed;

        public Car(string registrationNumber, int kilowattEffect, int maxSpeed, string color)
        {
            RegistrationNumber = registrationNumber;
            KilowattEffect = kilowattEffect;
            MaxSpeed = maxSpeed;
            Color = color;
        }

        public void ShowInfo()
    {
        Console.WriteLine($"Registration Number: {RegistrationNumber}");
        Console.WriteLine($"Kilowatt Effect:     {KilowattEffect}");
        Console.WriteLine($"Max Speed:           {MaxSpeed}");
        Console.WriteLine($"Color:               {Color}");
    }
    }

}
