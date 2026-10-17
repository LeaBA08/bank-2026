class CurrentAccount
{
    public string? Number;
    public double Balance {get; private set;}
    public double CreditLine;
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