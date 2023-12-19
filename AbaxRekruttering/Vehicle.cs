using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    public abstract class Vehicle
    {
        public string Registration { get; set; }
        public int KilowattEffect { get; set; }

        public abstract void ShowInfo();

        public abstract void StartVehicle();
    }
}
