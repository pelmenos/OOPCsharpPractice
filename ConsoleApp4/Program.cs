namespace ConsoleApp4;

class Counter(int count)
{
    private int _count = count;
    
    public Counter() : this(0)
    {
    }
    
    public void Plus()
    {
        _count++;
    }

    public void Minus()
    {
        _count--;
    }

    public void State()
    {
        Console.WriteLine(_count);
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        Counter counter2 = new Counter(5);
        
        counter.State();
        counter2.State();
        
        counter.Plus();
        counter2.Minus();
        
        counter.State();
        counter2.State();
    }
}