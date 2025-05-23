// Link to the exercise: https://exercism.org/tracks/csharp/exercises/interest-is-interesting

using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
            return balance switch
        {
            < 0 => 3.213f,
            < 1000 => 0.5f,
            >= 1000 and < 5000 => 1.621f,
            >= 5000 => 2.475f
        };
    }

    public static decimal Interest(decimal balance)
    {
        return balance * ((decimal)InterestRate(balance) / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal cash = balance;

        do
        {
            cash += Interest(cash);
            years++;

        }while(cash <= targetBalance);

        return years;
    }
}