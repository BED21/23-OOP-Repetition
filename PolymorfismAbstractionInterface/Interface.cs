namespace InterfaceExample;

interface IAnimal
{
    void AnimalSound();
}

// Pig implementerar gränssnittet IAnimal
class Pig : IAnimal
{
    public void AnimalSound()
    {
        Console.WriteLine("Grisen säger nöff nöff");
    }
}

class Dog : IAnimal
{
    public void AnimalSound()
    {
        Console.WriteLine("Hunden säger vov vov");
    }
}

// Vi kör med flera gränssnitt (Interface)
interface IFirstInterface
{
    void myMethod(); // interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // interface method
}

class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Litet text från första metoden");
    }

    public void myOtherMethod()
    {
        Console.WriteLine("Mer text från den andra metoden...");
    }
}
