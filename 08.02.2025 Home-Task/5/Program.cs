using System;

class Program
{
    static void Main(string[] args)
    {

    }
}
class Payment
{
    private decimal _Balance;
    public void GetBalance()
    {
        System.Console.WriteLine($"Your balanace: {_Balance}");
    }
    public void AddMoney(decimal amount)
    {
        _Balance += amount;
        GetBalance();
    }
    public void TakeMoney()
    {
        System.Console.WriteLine("Choose available payment: \nBy cash \n2. By credit card");
        char s = char.Parse(Console.ReadLine());
        decimal amount;
        switch (s)
        {
            case '1':
                System.Console.WriteLine($"Сколько хотите взять со счета: ");
                amount = decimal.Parse(Console.ReadLine());
                TakeMoneyByCash(amount);
                break;
            case '2':
                System.Console.WriteLine($"Сколько хотите взять со счета: ");
                amount = decimal.Parse(Console.ReadLine());
                TakeMoneyByTerminal(amount);
                break;
            default:
                System.Console.WriteLine("Неверная операция!");
                break;
        }

    }
    public void TakeMoneyByCash(decimal amount)
    {
        _Balance -= amount;
        GetBalance();
    }
    public void TakeMoneyByTerminal(decimal amount)
    {
        _Balance -= amount;
        GetBalance();
    }
}