using Tasks.Entities;
using Tasks.Entities.Vehicles;

var PassengerCar = new PassengerCar(
    "Passenger car",
    new Engine
{
    Power = 200,
    SerialNumber = "a1",
    Volume = 1.5,
    Type = "B"
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
    Type = "Type-1"
} );

var Bus = new Bus(
    "Bus",
    new Engine
    {
        Power = 200,
        SerialNumber = "a1",
        Volume = 1.5,
        Type = "B"
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
        Type = "Type-1"
    });

var Truck = new Truck(
    "Truck",
    new Engine
    {
        Power = 200,
        SerialNumber = "a1",
        Volume = 1.5,
        Type = "B"
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
        Type = "Type-1"
    });

var Scooter = new Scooter(
    "Scooter",
    new Engine
    {
        Power = 200,
        SerialNumber = "a1",
        Volume = 1.5,
        Type = "B"
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
        Type = "Type-1"
    });


var Vehicles = new List<Vehicle>() { PassengerCar, Bus, Scooter, Truck };
foreach (var item in Vehicles)
{
    item.DisplayInfo();
}
 