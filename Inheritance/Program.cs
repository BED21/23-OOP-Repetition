List<Animal> forrest = new List<Animal>();

forrest.Add(new Owl(7, true, 34));
forrest.Add(new Horse(740, false, 70));
forrest.Add(new Dolphin(432, false, 95));

foreach (var animal in forrest)
{
    Console.WriteLine($"Weight: {animal.Weight}");
    Console.WriteLine($"Nocturnal: {animal.Nocturnal}");

    if (animal is Owl)
    {
        Console.WriteLine($"Wingspan: {((Owl)animal).Wingspan}");
    }
    if (animal is Dolphin)
    {
        Console.WriteLine($"Fish per day: {((Dolphin)animal).FishPerDay}");
    }
    if (animal is Horse)
    {
        Console.WriteLine($"Hay per day: {((Horse)animal).HayPerDay}");
    }
}

Console.ReadKey();

class Animal
{
    public Animal(int weight, bool nocturnal)
    {
        Weight = weight;
        Nocturnal = nocturnal;
    }

    public int Weight { get; set; }
    public bool Nocturnal { get; set; }
}

class Owl : Animal
{
    public Owl(int weight, bool nocturnal, int wingspan) 
        : base(weight, nocturnal)
    {
        Wingspan = wingspan;
    }

    public int Wingspan { get; set; }
}
class Dolphin : Animal
{
    public Dolphin(int weight, bool nocturnal, int fishPerDay)
        : base(weight, nocturnal)
    {
        FishPerDay = fishPerDay;
    }

    public int FishPerDay { get; set; }

}
class Horse : Animal
{
    public Horse(int weight, bool nocturnal, int hayPerDay)
        : base(weight, nocturnal)
    {
        HayPerDay = hayPerDay;
    }

    public int HayPerDay { get; set; }
}