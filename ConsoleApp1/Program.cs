namespace ConsoleApp1;
class Student
{
    private string _surname;
    private string _birth;
    private int _group;
    private int[] _perfomance;
    
    public void SetSurname(string surname)
    {
        this._surname = surname;
    }
    
    public void SetBirth(string birth)
    {
        this._birth = birth;
    }
    
    public void SetGroup(int group)
    {
        this._group = group;
    }
    
    public void Print()
    {
        Console.WriteLine($"Имя: {_surname}  Дата рождения: {_birth}");
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.SetSurname("Швында");
        student.SetGroup(624);
        student.SetBirth("27-04-2006");
        student.Print();
    }
}