using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    public class JetSki : IVehicle, IWaterVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.5;
        public double MaxWaterSpeed { get; set; } = 33.5;
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Fly()
        {
            throw new NotImplementedException();
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
