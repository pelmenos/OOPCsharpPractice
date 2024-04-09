namespace ConsoleApp2;
class Train
{
    private int _number;
    private string _departureTime;
    private string _destination;

    public void SetNumber(int number)
    {
        this._number = number;
    }
    
    public void Print()
    {
        Console.WriteLine($"Номер поезда: {_number}");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Train train = new Train();
        train.SetNumber(123);
        train.Print();
    }
}
