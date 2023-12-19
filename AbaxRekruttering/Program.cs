using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbaxRekruttering
{
    internal class Program
    {
        //Printe informasjon om en en bil 1 med reg.nr NF123456,
        //    147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy.               

        //Printe informasjon om en annen bil (bil 2) med reg.nr NF654321, 150kw effekt,
        //    maksfart 195km/t, blå farge og av typen lett kjøretøy                            

        //Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet

        //Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt,
        //    30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly

        //Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.

        //Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet

        //Printe informasjon om en båt med kjennetegn ABC123, 100kw effekt,
        //maksfart på 30knop, 500kg bruttotonnasje.
        static void Main(string[] args)
        {
            var car1 = new Car("NF123456", 147, 200, "Green");
            var car2 = new Car("NF654321", 150, 195, "Blue");

            //car1.ShowInfo();
            //Console.WriteLine();
            //car2.ShowInfo();
            //Console.WriteLine();

            //if (car1.GetType() == car2.GetType())
            //{
            //    Console.WriteLine("They are the same vehicle Type.");

            //    if (car1 != car2)
            //        Console.WriteLine("But they are not the same car.");
            //}
            //else
            //    Console.WriteLine("They are NOT the same vehicle type.");

            var jetPlane = new JetPlane("LN1234", 1000, 30, 2, 10);

            //jetPlane.ShowInfo();
            //Console.WriteLine();
            //jetPlane.StartVehicle();

            //car1.StartVehicle();

            var boat = new Boat("ABC123", 100, 30, 500);

            boat.ShowInfo();
        }
    }
}
