
using System;

struct Money
{
    public decimal Amount { get; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    // Overload the + operator to add two Money objects
    public static Money operator +(Money m1, Money m2)
    {
        return new Money(m1.Amount + m2.Amount);
    }

    // Overload the - operator to subtract two Money objects
    public static Money operator -(Money m1, Money m2)
    {
        return new Money(m1.Amount - m2.Amount);
    }

    // Overload the == operator to compare two Money objects
    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Amount == m2.Amount;
    }

    // Overload the != operator to compare two Money objects
    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    }

    // Overload the > operator to check if one Money object is greater than another
    public static bool operator >(Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;
    }

    // Overload the < operator to check if one Money object is less than another
    public static bool operator <(Money m1, Money m2)
    {
        return m1.Amount < m2.Amount;
    }

    // Override ToString for a readable representation
    public override string ToString()
    {
        return $"{Amount:C}"; // Format as currency
    }
}

class Program
{
    static void Main()
    {
        Money wallet1 = new Money(100.50m);
        Money wallet2 = new Money(50.25m);

        // Adding two Money objects
        Money total = wallet1 + wallet2;
        Console.WriteLine($"Total: {total}");

        // Subtracting two Money objects
        Money difference = wallet1 - wallet2;
        Console.WriteLine($"Difference: {difference}");

        // Comparing two Money objects
        Console.WriteLine($"Is wallet1 greater than wallet2? {wallet1 > wallet2}");
        Console.WriteLine($"Is wallet1 less than wallet2? {wallet1 < wallet2}");
        Console.WriteLine($"Are wallet1 and wallet2 equal? {wallet1 == wallet2}");

        // Creating another Money object for comparison
        Money wallet3 = new Money(100.50m);
        Console.WriteLine($"Are wallet1 and wallet3 equal? {wallet1 == wallet3}");
    }
}