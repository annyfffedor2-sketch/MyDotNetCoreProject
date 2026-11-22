using System;

public class Greeter
{
    public void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Greeter greeter = new Greeter();

        greeter.GreetUser("World");
        greeter.GreetUser("User");
        greeter.GreetUser("Anna");
    }
}
