using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    public interface IAirVehicle
    {
        // an int property called Wheels
        int Wheels { get; set; }
        // a bool property called Winged
        bool Winged { get; set; }
        // a double property called MaxAirSpeed 
        double MaxAirSpeed { get; set; }

        // a method called Fly() that returns void
        void Fly();
    }

}
