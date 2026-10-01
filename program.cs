//1.(base Class)
class Vehicle
{ 
    public string Brand {  get; set; }
    public int Year {  get; set; }
public Vehicle(string brand, int year)
{
Brand = brand;
Year = year;
}

public virtual void Start()
{
Console.WriteLine($"The vehicle {Brand} ({Year}) is starting.");
}
}
class Car : Vehicle
{ 
    public int NumperOfDoors {  get; set; }
public Car(string brand, int year, int numberOfDoors) : base(brand, year)
{
        NumperOfDoors = numberOfDoors;
}
}
class Bus : Vehicle
{ 
    public int Capacity {  get; set; }
public Bus(string brand, int year, int capacity) : base(brand, year)
{
Capacity = capacity;
}
}
class Motorcycle : Vehicle
{ 
    public bool HasSidecar {  get; set; }

public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
{
HasSidecar = hasSidecar;
}
}
class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", 2023, 4);
        Bus myBus = new Bus("Merceds", 2021, 50);
        Motorcycle myMotorcycle = new Motorcycle("Haraley-Davison", 2024, false);
        myCar.Start();
        myBus.Start();
        myMotorcycle.Start();
    }