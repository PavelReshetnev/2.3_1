using System;
namespace ConsoleApp2._3;

public class Worker
{
    public string Name;
    public string Surname;
    public int Rate;
    public int Days;

    public Worker(string Name, string Surname, int Days, int Rate) {
        this.Name = Name;
        this.Surname = Surname;
        this.Days = Days;
        this.Rate = Rate;
    }
    public string name { 
        get => this.Name; 
        set => this.Name = value;
    }
    public string surname { 
        get => this.Surname; 
        set => this.Surname = value;
    }
    public int rate { 
        get => this.Rate; 
        set => this.Rate = value;
    }
    public int days { 
        get => this.Days; 
        set => this.Days = value;
    }
    

    public void Get_Salary()
    {
        int sar = Rate * Days;
        Console.WriteLine($"{Name} {Surname} заработал {sar} рублей");
    }

}