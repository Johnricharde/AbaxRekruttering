﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    public class Car : LightVehicle
    {
        string Color {  get; set; }

        public Car(string registration, int kilowattEffect, int maxSpeed, string color)
        {
            Registration = registration;
            KilowattEffect = kilowattEffect;
            MaxSpeed = maxSpeed;
            Color = color;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Registration:     {Registration}");
            Console.WriteLine($"Kilowatt Effect:  {KilowattEffect} kw");
            Console.WriteLine($"Max Speed:        {MaxSpeed} km/h");
            Console.WriteLine($"Color:            {Color}");
        }

        public override void StartVehicle()
        {
            Console.WriteLine("You start the car.");
        }
    }
}
