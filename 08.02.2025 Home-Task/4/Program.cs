using System;

class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter(1);
        counter.Value = 5;
        counter.Increase(5);
        System.Console.WriteLine(counter.Value);
        counter.Decrease();
        System.Console.WriteLine(counter.Value);
        counter.Decrease(6);
        System.Console.WriteLine(counter.Value);
    }
}
class Counter
{
    public int Value { get; set; }
    public Counter(int startValue)
    {
        Value = 0;
    }
    public void Increase()
    {
        Value++;
    }
    public void Increase(int increaseBy)
    {
        if (increaseBy < 0)
        {
            return;
        }
        Value += increaseBy;
    }
    public void Decrease()
    {
        Value--;
    }
    public void Decrease(int decreaseBy)
    {
        if (decreaseBy < 0)
        {
            return;
        }
        Value -= decreaseBy;
    }
}