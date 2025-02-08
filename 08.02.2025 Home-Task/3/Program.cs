using System;

class Program
{
    static void Main(string[] args)
    {
        Gauge gauge = new Gauge();
        gauge.Value = int.Parse(Console.ReadLine());
        System.Console.WriteLine(gauge.Full());
        System.Console.WriteLine(gauge.Value);
    }
}

class Gauge
{
    private int _value;
    public int Value
    {
        get => _value;
        set
        {
            if (value <= 5 && value >= 0)
                _value = value;
        }
    }
    public Gauge()
    {
        this.Value = 0;
    }
    public void Enhance()
    {
        if (Value < 5)
        {
            Value++;
        }
    }
    public void Decrease()
    {
        if (Value > 0)
        {
            Value--;
        }
    }
    public bool Full()
    {
        return Value == 5;
    }
}