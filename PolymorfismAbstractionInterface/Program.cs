
// Standard
//using Standard;

Console.WriteLine("Standard");
Standard.Animal myAnimal = new Standard.Animal();
Standard.Animal myPig = new Standard.Pig();
Standard.Animal myDog = new Standard.Dog();
Standard.Dog myOtherDog = new Standard.Dog();

myAnimal.AnimalSound();
myPig.AnimalSound();
myDog.AnimalSound();
myOtherDog.AnimalSound();


Console.WriteLine("\n--------------------");

// Polymorphism
Console.WriteLine("Polymorphism");
Polymorphism.Animal myAnimal2 = new Polymorphism.Animal();  // Create a Animal object
Polymorphism.Animal myPig2 = new Polymorphism.Pig();        // Create a Pig object
Polymorphism.Animal myDog2 = new Polymorphism.Dog();        // Create a Dog object

myAnimal2.AnimalSound();
myPig2.AnimalSound();
myDog2.AnimalSound();


Console.WriteLine("\n--------------------");

// Abstract
Console.WriteLine("Abstract");
//Abstract.Animal myObj3 = new Abstract.Animal();   // Detta fungerar inte, eftersom det är en abstrakt klass.
Abstract.Animal myPig3 = new Abstract.Pig();        // Create a Pig object
myPig3.AnimalSound();                               // Call the abstract method
myPig3.Sleep();                                     // Call the regular method

Console.WriteLine("\n--------------------");
// Intertface
Console.WriteLine("Interface");
InterfaceExample.Pig myPig4 = new InterfaceExample.Pig();
myPig4.AnimalSound();
InterfaceExample.IAnimal myDog4 = new InterfaceExample.Dog();
myDog4.AnimalSound();


Console.WriteLine("\n--------------------");
// Multipla Intertface
Console.WriteLine("Multipla Interface");
InterfaceExample.DemoClass myDemoClass = new InterfaceExample.DemoClass();
myDemoClass.myMethod();
myDemoClass.myOtherMethod();


Console.ReadKey();