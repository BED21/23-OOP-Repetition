Car volvo = new Car();
volvo.Make = "Volvo";
volvo.Model = "S90";
volvo.Year = 2017;

Car bmw = new Car("BMW", "320", 2020);

//PrintCar(volvo);
//PrintCar(bmw);

Console.WriteLine(volvo.ToString());
Console.WriteLine(bmw.ToString());


Console.ReadKey();



void PrintCar(Car car)
{
    Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
}

public class Car
{
    public Car()
    {
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{this.Make} {this.Model} {this.Year}";
    }

}