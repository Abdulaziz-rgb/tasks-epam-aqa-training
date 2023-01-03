﻿using Tasks.Entities;
using Tasks.Entities.Vehicles;

var PassengerCar = new PassengerCar(
    "Passenger car",
    new Engine
{
    Power = 200,
    SerialNumber = "8uthg7e",
    Volume = 1.5,
    Type = "Diesel"
}, 
    new Chassis
{
    Number = 2,
    PermissibleLoad = 4000,
    WheelsNumber = 6,
}, 
    new Transmission
{
    Manufacturer = "Hyundai",
    NumberOfGears = 5,
    Type = "Automatic"
} );

var Bus = new Bus(
    "Bus",
    new Engine
    {
        Power = 500,
        SerialNumber = "c2daqt5",
        Volume = 1.8,
        Type = "Petrol"
    },
    new Chassis
    {
        Number = 3,
        PermissibleLoad = 3000,
        WheelsNumber = 8,
    },
    new Transmission
    {
        Manufacturer = "Toyota",
        NumberOfGears = 5,
        Type = "Automatic"
    });

var Truck = new Truck(
    "Truck",
    new Engine
    {
        Power = 800,
        SerialNumber = "5ht73hs",
        Volume = 4.0,
        Type = "Diesel"
    },
    new Chassis
    {
        Number = 4,
        PermissibleLoad = 6000,
        WheelsNumber = 6,
    },
    new Transmission
    {
        Manufacturer = "Man",
        NumberOfGears = 5,
        Type = "Manual"
    });

var Scooter = new Scooter(
    "Scooter",
    new Engine
    {
        Power = 100,
        SerialNumber = "7gh5hu4",
        Volume = 1.0,
        Type = "Petrol"
    },
    new Chassis
    {
        Number = 0,
        PermissibleLoad = 70,
        WheelsNumber = 2,
    },
    new Transmission
    {
        Manufacturer = "BMW",
        NumberOfGears = 3,
        Type = "Manual"
    });

var vehicles = new List<Vehicle>() { PassengerCar, Bus, Scooter, Truck };

// All information about all vehicles an engine capacity of which is more than 1.5 liters;
var VehiclesWithEngineCapacity = vehicles
    .Where(vehicle => vehicle.Engine.Volume > 1.5)
    .ToList();


// Engine type, serial number and power rating for all buses and trucks;
var VehiclesOfBussesAndTrucks = vehicles
    .Where(vehicle => vehicle.Name == "Bus" || vehicle.Name == "Truck")
    .ToList();


// All information about all vehicles, grouped by transmission type
var VehiclesGroupedByTransmissionType = vehicles
    .Where(vehicle => vehicle.Transmission.Type == "Manual")
    .ToList();

// Couldn't convert these objects into XML :)
// The problem was that XMLSerializer can only function with parameterless constructor
 