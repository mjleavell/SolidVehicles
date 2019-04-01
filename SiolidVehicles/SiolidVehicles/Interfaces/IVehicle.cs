﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{

    // Contains the properties that Air, Land, and Water vehicles have in common
    public interface IVehicle
    {
        // an int property called Doors
        int Doors { get; set; }
        // an int property called PassengerCapacity
        int PassengerCapacity { get; set; }
        // a string property called TransmissionType 
        string TransmissionType { get; set; }
        // a double property called EngineVolume 
        double EngineVolume { get; set; }

        // a method called Start() that returns void 
        void Start();
        // a method called Stop() that returns void 
        void Stop();
    }
}
