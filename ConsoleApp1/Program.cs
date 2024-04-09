namespace ConsoleApp1;

class Worker(string name, string surname, int days, int rate)
{
    private string _name = name;
    private string _surname = surname;
    private int _days = days;
    private int _rate = rate;

    public string GetName()
    {
        return _name;
    }
    public string GetSurname()
    {
        return _surname;
    }
    public int GetDays()
    {
        return _days;
    }
    public int GetRate()
    {
        return _rate;
    }

    public void GetSalary()
    {
        Console.WriteLine(_days * _rate);
    }
}

class Calculation(string calculationLine)
{
    public string GetCalculationLine()
    {
        return calculationLine;
    }
    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }
    
    public char GetLastSymbolCalculationLine()
    {
        return calculationLine[^1];
    }

    public void SetLastSymbolCalculationLine(string sym)
    {
        calculationLine = calculationLine + sym;
    }

    public void DeleteLastSymbol()
    {
        calculationLine = calculationLine.Remove(calculationLine.Length - 1);
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Calculation calc = new Calculation("asd");
        calc.SetLastSymbolCalculationLine("d");
        Console.WriteLine(calc.GetCalculationLine());
        Console.WriteLine(calc.GetLastSymbolCalculationLine());
        calc.DeleteLastSymbol();
        Console.WriteLine(calc.GetCalculationLine());
    }
}

