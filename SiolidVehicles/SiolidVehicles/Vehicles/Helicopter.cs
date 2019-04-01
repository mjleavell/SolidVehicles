using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    public class Helicopter : IVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 19.8;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; } = 117.0;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The helicopter is a great way to fly");
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
