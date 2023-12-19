using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    public class Boat : LightVehicle
    {
        int GrossTonnage {  get; set; }

        public Boat(string registration, int kilowattEffect, int maxSpeed, int grossTonnage)
        {
            Registration = registration;
            KilowattEffect = kilowattEffect;
            MaxSpeed = maxSpeed;
            GrossTonnage = grossTonnage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Registration:     {Registration}");
            Console.WriteLine($"Kilowatt Effect:  {KilowattEffect} kw");
            Console.WriteLine($"Max Speed:        {MaxSpeed} kt");
            Console.WriteLine($"Gross Tonnage:    {GrossTonnage} kg");
        }

        public override void StartVehicle()
        {
            Console.WriteLine("You start the boat.");
        }
    }
}
