class SavingsAccount
{
    public string? Number;
    public double Balance;
    public DateTime DateLastWithdraw;
    public Person? Owner;

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}