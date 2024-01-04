class CreditCard
{
    public string CardNumber { get; set; }
    public int Cvc { get; set; }
    public double Balance { get; set; }

    public static CreditCard operator +(CreditCard card, double amount)
    {
        card.Balance += amount;
        return card;
    }

    public static CreditCard operator -(CreditCard card, double amount)
    {
        card.Balance -= amount;
        return card;
    }

    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        return card1.Cvc == card2.Cvc;
    }

    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return !(card1 == card2);
    }

    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.Balance > card2.Balance;
    }

    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.Balance < card2.Balance;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        CreditCard other = (CreditCard)obj;
        return this.Cvc == other.Cvc;
    }
}

class Program
{
    static void Main()
    {
        CreditCard card1 = new CreditCard { CardNumber = "1234-5678-9101-1121", Cvc = 123, Balance = 1000.0 };
        CreditCard card2 = new CreditCard { CardNumber = "2101-1121-3456-7890", Cvc = 123, Balance = 1500.0 };

        Console.WriteLine($"CVC равны: {card1 == card2}");
        Console.WriteLine($"Карта 1 > Карта 2: {card1 > card2}");
        Console.WriteLine($"Карта 1 < Карта 2: {card1 < card2}");

        card1 += 500.0;
        card2 -= 200.0;

        Console.WriteLine($"Баланс картки 1 : {card1.Balance}");
        Console.WriteLine($"Баланс картки 2 : {card2.Balance}");
    }
}
