using SolidVehicles.Interfaces;
using SolidVehicles.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{

    public class AirVehicleRepository
    {
        public List<IAirVehicle> _airVehicles = new List<IAirVehicle>();

        public AirVehicleRepository()
        {
            _airVehicles = new List<IAirVehicle>();
        }
    }

    public class LandVehicleRepository
    {
        public List<ILandVehicle> _landVehicles = new List<ILandVehicle>();

        public LandVehicleRepository()
        {
            _landVehicles = new List<ILandVehicle>();
        }
    }

    public class WaterVehicleRepository
    {
        public List<IWaterVehicle> _waterVehicles = new List<IWaterVehicle>();

        public WaterVehicleRepository()
        {
            _waterVehicles = new List<IWaterVehicle>();
        }
    }

    public static void Main()
    {
        // Build a collection of all vehicles that fly
        var airVehicles = new List<IAirVehicle>();

        var airplane = new Airplane();
        var cessna = new Cessna();
        var heli = new Helicopter();

        airVehicles.Add(airplane);

        // With a single `foreach`, have each vehicle Fly()


        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
    }



}