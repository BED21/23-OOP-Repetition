Person p1 = new Person();
var p2 = new Person();

string pNamn = p1.Name;
p1.Name = "Kalle";
p1.BirthYear = 1984;
//p1.Age = 38;
int age = p1.Age;
Console.WriteLine(Person.BuildStory(p1));


public class Person
{
    public string Name { get; set; }
    public int BirthYear { get; set; }
    public bool HasCar { get; set; }
    public int Age { get
        {
            var age = DateTime.Now.Year - BirthYear;
            return age;
        }  
    }

    public static string BuildStory(Person p)
    {
        string story = $"Det var en gång en person som hette {p.Name}. Hen var {p.Age} år gammal.";
        if (p.HasCar)
        {
            story += $" {p.Name} hade en väldigt fin bil.";
        }
        else
        {
            story += $" {p.Name} hade ingen bil. Snyft...";
        }

        return story;
    }
}