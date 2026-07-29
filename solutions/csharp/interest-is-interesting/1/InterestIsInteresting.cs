static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0.0m) return 3.213f;
        if (balance >= 0.0m && balance < 1000.0m) return 0.5f;
        if (balance >= 1000.0m && balance < 5000.0m) return 1.621f;
        if (balance >= 5000.0m) return 2.475f;

        return 0.0f;
    }

    public static decimal Interest(decimal balance)
    {
        decimal juros = 0.0m;

        if (balance < 0.0m) juros = 3.213m;
        if (balance >= 0.0m && balance < 1000.0m) juros = 0.5m;
        if (balance >= 1000.0m && balance < 5000.0m) juros = 1.621m;
        if (balance >= 5000.0m) juros = 2.475m;

        decimal saldo = balance * (juros / 100m);

        return saldo;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal saldo = Interest(balance);

        decimal saldoFinal = balance + saldo;

        return saldoFinal;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;

        while (balance < targetBalance)
        {
            years++;
            balance = AnnualBalanceUpdate(balance);
        }

        return years;
    }
}
