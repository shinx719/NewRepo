using System;

public abstract class BankAccount
{
    protected double balance;

    public BankAccount(double balance = 0)
    {
        this.balance = balance;
    }

    public abstract void Withdraw(double amount);

    public  void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Пополнено: {amount}. Баланс = {balance}");
        }
    }
}

public class SavingAccount : BankAccount // Сберегательный счет
{
    private double savingAccountBalance;

    public SavingAccount(double balance = 0, double savingAccountBalance = 100) : base(balance)
    {
        this.savingAccountBalance = savingAccountBalance;
    }

    public override void Withdraw(double amount)
    {
        if (balance - amount >= savingAccountBalance)
        {
            balance -= amount;
            Console.WriteLine($"Снято {amount}. Текущий баланс = {balance}");
        }
        else
        {
            Console.WriteLine($"Недостаточно средств. Минимальный баланс должен составлять {savingAccountBalance}.");
        }
    }
}

public class CheckingAccount : BankAccount // Расчетный счет
{
    private double service;

    public CheckingAccount(double balance = 0, double service = 5) : base(balance)
    {
        this.service = service;
    }

    public override void Withdraw(double amount)
    {
        double totalAmount = amount + service;
        if (balance >= totalAmount)
        {
            balance -= totalAmount;
            Console.WriteLine($"Снято: {amount} (Плата за обслуживание {service}). Текущий баланс = {balance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств для снятия");
        }
    }
}

class Program
{
    static void Main()
    {
        SavingAccount savings = new SavingAccount(200);
        savings.Deposit(50);         
        savings.Withdraw(100);      
        savings.Withdraw(150);        

        CheckingAccount checking = new CheckingAccount(300);
        checking.Deposit(100);       
        checking.Withdraw(50);       
        checking.Withdraw(400);
        Console.ReadLine();
    }
}
