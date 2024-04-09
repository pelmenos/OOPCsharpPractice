namespace ConsoleApp5;

public class Human(string name = "Vadim", int age = 17)
{
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Дата рождения: {age}");
    }
    
    ~Human()
    {
        Console.WriteLine(name + " уничтожен");
    }
}


class Program
{
    static void Test()
    {
        Human vadim = new Human();
        Human dima = new Human("Dima", 20);
    }
    
    static void Main(string[] args)
    {
        Test();
        GC.Collect();
    }
}