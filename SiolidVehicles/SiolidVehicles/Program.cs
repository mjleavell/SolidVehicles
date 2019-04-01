using SolidVehicles.Interfaces;
using SolidVehicles.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    public static void Main()
    {
        // Build a collection of all vehicles that fly
        var airVehicles = new List<IAirVehicle>();

        var airplane = new Airplane();
        var cessna = new Cessna();
        var heli = new Helicopter();

        airVehicles.Add(airplane);
        airVehicles.Add(cessna);
        airVehicles.Add(heli);


        // With a single `foreach`, have each vehicle Fly()


        // Build a collection of all vehicles that operate on roads
        var landVehicles = new List<ILandVehicle>();

        var car = new Car();
        var motorcycle = new Motorcycle();

        landVehicles.Add(car);
        landVehicles.Add(motorcycle);

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water
        var waterVehicles = new List<IWaterVehicle>();

        var jetSki = new JetSki();

        waterVehicles.Add(jetSki);

        // With a single `foreach`, have each water vehicle Drive()
    }



}