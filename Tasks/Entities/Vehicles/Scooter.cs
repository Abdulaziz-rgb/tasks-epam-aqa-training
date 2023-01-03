namespace Tasks.Entities.Vehicles;

public class Scooter: Vehicle
{
    public Scooter(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
    { }
}