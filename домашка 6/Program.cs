using System;

public class Building
{
    private int number;           
    private double height;      
    private int floors;         
    private int flats;          
    private int entrances;     

    private static int lastNumber = 0; 

    public Building(double height, int floors, int flats, int entrances)
    {
        lastNumber++;
        this.number = lastNumber;
        this.height = height;
        this.floors = floors;
        this.flats = flats;
        this.entrances = entrances;
    }

    public int GetNumber() { return number; }
    public double GetHeight() { return height; }
    public int GetFloors() { return floors; }
    public int GetFlats() { return flats; }
    public int GetEntrances() { return entrances; }

    public void SetHeight(double h) { height = h; }
    public void SetFloors(int f) { floors = f; }
    public void SetFlats(int f) { flats = f; }
    public void SetEntrances(int e) { entrances = e; }

    
    public double FloorHeight()
    {
        return height / floors;
    }

    public double FlatsPerEntrance()
    {
        return (double)flats / entrances;
    }

   
    public double FlatsPerFloor()
    {
        return (double)flats / floors;
    }

    public void Print()
    {
        Console.WriteLine($"Здание № {number}");
        Console.WriteLine($"  Высота: {height} м, этажей: {floors}");
        Console.WriteLine($"  Квартир: {flats}, подъездов: {entrances}");
        Console.WriteLine($"  Высота этажа: {FloorHeight():F2} м");
        Console.WriteLine($"  Квартир в подъезде: {FlatsPerEntrance():F2}");
        Console.WriteLine($"  Квартир на этаже: {FlatsPerFloor():F2}");
    }
}

class Program
{
    static void Main()
    {
        Building b1 = new Building(30, 10, 120, 4);
        b1.Print();

        b1.SetFlats(140);
        b1.Print();

        Building b2 = new Building(15, 5, 60, 2);
        b2.Print();
    }
}