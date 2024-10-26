using System;

namespace DXcarrace.Classes;

public class Car
{
    public string Model ;
    public string Color;
    public double speed;
    public double Fuel;
    public double totalMile;
    public double UseFuelRate; // xxx mile per mile
    public Car(string model , double speed , double fuel)
    {
        this.Model = model;
        this.speed = speed;
        this.Fuel = fuel;
    }

    public void Run(double mile)
    {
        //this.totalDistance = this.TotalDistance + distance
        this.totalMile += mile;
        var use_fuel = mile * this.UseFuelRate ;
        this.Fuel = this.Fuel - use_fuel;
    }

    public uint TimeUseFormRun(double mile)
    {
        var timeuse = mile/speed;
        this.Run(mile);
        return Convert.ToUInt16(timeuse);
    }

    public string ShowInfo()
    {
        var info = $"Model { this.Model } \nTotal Mile : { this.totalMile } \nFuel : {this.Fuel }";
        return info;
    }
}
