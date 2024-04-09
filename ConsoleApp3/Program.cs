namespace ConsoleApp3;

class Calculator(int number, int number2)
{
    public void SetNumber(int number1)
    {
        number = number1;
    }
    
    public void SetNumber2(int number3)
    {
        number2 = number3;
    }

    public int Sum()
    {
        return number + number2;
    }

    public int Better()
    {
        if (number > number2) return number;
        else return number2;
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator(5, 6);
        Console.WriteLine("Сумма чисел: " + calc.Sum());
        calc.SetNumber(10);
        calc.SetNumber2(20);
        Console.WriteLine("Большее из изменённых чисел: " + calc.Better());
    }
}