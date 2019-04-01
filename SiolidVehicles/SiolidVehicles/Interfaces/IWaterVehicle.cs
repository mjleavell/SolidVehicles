using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    public interface IWaterVehicle
    {
        // a double property called MaxWaterSpeed 
        double MaxWaterSpeed { get; set; }

        // a method called Drive() that returns void 
        void Drive();
    }
}
