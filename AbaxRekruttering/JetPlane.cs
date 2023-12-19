using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    public class JetPlane : Vehicle
    {
        int Wingspan {  get; set; }
        int Weight { get; set; }
        int StorageCapacity { get; set; }

        public JetPlane(string registration, int kilowattEffect,  int wingspan, int weight, int storageCapacity)
        {
            Registration = registration;
            KilowattEffect = kilowattEffect;
            Wingspan = wingspan;
            Weight = weight;
            StorageCapacity = storageCapacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Registration:     {Registration}");
            Console.WriteLine($"Kilowatt Effect:  {KilowattEffect} kw");
            Console.WriteLine($"Wingspan:         {Wingspan} m");
            Console.WriteLine($"Weight:           {Weight} t");
            Console.WriteLine($"Storage Capacity: {StorageCapacity} t");
        }

        public override void StartVehicle()
        {
            Console.WriteLine("You start the jet plane.");
        }
    }
}
