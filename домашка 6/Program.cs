using System;
public enum AccountType
{
    Текущий,
    Сберегательный,
    Кредитный
}


public class BankAccount
{
    private int number;           
    private decimal balance;        
    private AccountType type;       

    private static int lastNumber = 1000; 

    public BankAccount(decimal balance, AccountType type)
    {
        lastNumber++;
        this.number = lastNumber;
        this.balance = balance;
        this.type = type;
    }

    public int GetNumber() { return number; }
    public decimal GetBalance() { return balance; }
    public AccountType GetType() { return type; }

    public void SetBalance(decimal b) { balance = b; }
    public void SetType(AccountType t) { type = t; }

    public void Deposit(decimal sum)
    {
        balance = balance + sum;
        Console.WriteLine($"Положено {sum}. Баланс: {balance}");
    }

    public bool Withdraw(decimal sum)
    {
        if (sum > balance)
        {
            Console.WriteLine("Недостаточно!");
            return false;
        }
        balance = balance - sum;
        Console.WriteLine($"Снято {sum}. Баланс: {balance}");
        return true;
    }

    public void Print()
    {
        Console.WriteLine($"Счёт № {number}, баланс = {balance}, тип = {type}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(1500m, AccountType.Сберегательный);
        acc1.Print();

        acc1.Deposit(500m);
        acc1.Withdraw(200m);
        acc1.Withdraw(10000m);
        acc1.Print();

        BankAccount acc2 = new BankAccount(300m, AccountType.Текущий);
        acc2.Print();
    }
}