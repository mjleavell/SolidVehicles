using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    public interface ILandVehicle
    {
        // an int property called Wheels
        int Wheels { get; set; }
        // a double property called MaxLandSpeed 
        double MaxLandSpeed { get; set; }

        // a method called Drive() that returns void 
        void Drive();
    }
}
