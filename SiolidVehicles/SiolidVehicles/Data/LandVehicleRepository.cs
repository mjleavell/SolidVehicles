using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Data
{
    public class LandVehicleRepository
    {
        public List<ILandVehicle> _landVehicles = new List<ILandVehicle>();

        public LandVehicleRepository()
        {
            _landVehicles = new List<ILandVehicle>();
        }
    }

}
