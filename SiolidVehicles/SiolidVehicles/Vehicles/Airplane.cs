using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    public class Airplane : IVehicle, IAirVehicle
    {
        public int Wheels { get; set; } = 18;
        public int Doors { get; set; } = 22;
        public int PassengerCapacity { get; set; } = 467;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 226118.0;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; } = 614.0;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The Boeing 747-8 is massive and fuel efficient airplane");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
