using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    public class Car : IVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 5;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Auto";
        public double EngineVolume { get; set; } = 3.0;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; } = 150.0;
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The infiniti q50 is a fast car");
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
