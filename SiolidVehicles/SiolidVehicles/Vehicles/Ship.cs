using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    public class Ship : IVehicle, IWaterVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 5020;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 500000;
        public double MaxWaterSpeed { get; set; } = 25.9;
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The Adventure of the Seas is a massive Royal Caribbean cruise ship");
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
