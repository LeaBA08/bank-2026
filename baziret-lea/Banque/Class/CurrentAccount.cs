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

    //Il n'est pas nécessaire de mettre un paramètre dans la méthode, car la méthode traite déjà le "current account".
    public double GetBalance()
    {
        return Balance;
    }

    


}