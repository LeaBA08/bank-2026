
abstract class Account : IAccount, IBankAccount
{
    public string? Number{get; private set;}
    public double Balance { get; private set; }
    public Person? Owner{get;private set;}

    public Account(string Number, Person Owner){
        this.Number = Number;
        this.Owner = Owner;
    }

    public Account(string Number, Person Owner, double Balance)
    {
        this.Number = Number;
        this.Owner = Owner;
        this.Balance = Balance;
    }

    //Note: "virtual" car le comportement de Withdraw change en fonction du type d'Account.
    public virtual void Withdraw(double amount)
    {
        if (amount <=0)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (Balance - amount < 0)
        {
            throw new InsufficientBalanceException();
        }
        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(); //il faut mettre "new", car x'est un objet de type Exception
        }
        Balance += amount;
    }

    //Note: quand une méthode est "abstraite", il faut d'office l'écrire dans les classes filles.
    protected abstract double CalculInterets();

    /*Ajouter une méthode « public » à la classe « Account » appelée « ApplyInterest » qui 
additionnera le solde avec le retour de la méthode « CalculInterest ».*/
    public void ApplyInterest()
    {
        Balance += CalculInterets();
    }
}
