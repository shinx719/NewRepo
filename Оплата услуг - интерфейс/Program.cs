using System.Numerics;

public interface IPaymentMethod
{
    void Pay();
}
class CreditCard : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Оплата картой");
    }
}
class PayPal : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Оплата через PayPal");
    }
}
class BankTransfer : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Оплата через банковсикй перевод");
    }
}
class OnlineShop
{
    public async Task check(IPaymentMethod method)
    {
        Console.WriteLine("Процесс оплаты...");
        await Task.Delay(2000);
        method.Pay();
        await Task.Delay(2000);
        Console.WriteLine("Оплата завершена.");
    }
}
class Program
{
    static async Task Main(string[] args)
    {
        OnlineShop cart = new OnlineShop();

        Console.WriteLine("Выберите способ оплаты:");
        Console.WriteLine("1. Оплата картой");
        Console.WriteLine("2. Оплата через PayPal");
        Console.WriteLine("3. Банковский перевод");

        IPaymentMethod paymentMethod = null;
        try
        {
            int ch = 0;
            ch = Convert.ToInt32(Console.ReadLine());
            while (ch != 0)
            {
                if (ch == 1)
                {
                    paymentMethod = new CreditCard();
                    break;
                }
                if (ch == 2)
                {
                    paymentMethod = new PayPal();
                    break;
                }
                if (ch == 3)
                {
                    paymentMethod = new BankTransfer();
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        await cart.check(paymentMethod);
        Console.ReadLine();
    }
}