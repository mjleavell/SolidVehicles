using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Data
{
    public class WaterVehicleRepository
    {
        public List<IWaterVehicle> _waterVehicles = new List<IWaterVehicle>();

        public WaterVehicleRepository()
        {
            _waterVehicles = new List<IWaterVehicle>();
        }
    }
}
