using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Part_2
{
    public struct Money
    {

        public const double USD = 1;
        public const double EUR = 0.74158;
        public const double GBP = 0.62587;
      

        double Amount;
        double Currency;

        public static Money operator +(Money c1, Money c2)
        {
            double value = c2.Amount * c2.Currency;
            
            return new Money(c1.Amount + value, c1.Currency);
        }
        
        public double retAmount()
        {
            return Amount;
        }
        public double retCurrency()
        {
            return Currency;
        }

        public Money(double amount, double currency)
            : this()
        {
            Amount = amount;
            Currency = currency;
        }

        public double conversion(double currentCurrency, double convertedCurrency, double amount)
        {
            Console.WriteLine(convertedCurrency + currentCurrency);
            Console.WriteLine(convertedCurrency);
            Console.WriteLine(currentCurrency);

            //Console.ReadLine();
            return amount * currentCurrency;
        }
        public Money combine(Money x, Money y)
        {
            double amount;
            
            amount = x.conversion(y.Currency, x.Currency, y.Amount);
            Money z = new Money(amount + x.Amount, x.Currency);
            return z;
        }

    }

    public class test
    {
        public static void Main()
        {
            Money x = new Money(10, Money.USD);
            Money y = new Money(10, Money.GBP);
            Money i = x + y;
            Money z = new Money();
            z = z.combine(x, y);
            Console.WriteLine("Amount:" + z.retAmount());
            Console.WriteLine("Amount:" + i.retAmount());
            Console.ReadLine();
        }
    }
}
