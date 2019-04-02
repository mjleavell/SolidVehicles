using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Data
{
    public class AirVehicleRepository
    {
        public List<IAirVehicle> _airVehicles = new List<IAirVehicle>();

        public AirVehicleRepository()
        {
            _airVehicles = new List<IAirVehicle>();
        }

        //public IAirVehicle AddAirVehicle()
        //{
        //    var newAirVehicle = new IAirVehicle();

        //    _airVehicles.Add(newAirVehicle);

        //    return newAirVehicle;
        //}
    }

}
