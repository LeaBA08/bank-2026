
class CurrentAccount : Account
{   
    //Constructeur nécessaire car il y en a un dans Account.
    // base() renvoie les info à Account
    public CurrentAccount(string number, Person owner, double creditLine)
        : base(number, owner)
    {
        CreditLine = creditLine;
    }

    /*
    On peut faire un "if" dans une propriété, pour ca, il faut d'abord
    écrire un champ privé qui stock la valeur.
    */
    private double _creditLine;
    public double CreditLine
    {
        get { return _creditLine; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _creditLine = value;
        }
    }
    

    //Il n'est pas nécessaire de mettre un paramètre dans la méthode,
    //  car la méthode traite déjà le "current account".
    public double GetBalance()
    {
        return Balance;
    }

    protected override double CalculInterets()
    {
        if (Balance > 0)
        {
            return Balance* 0.03;
        }
        return Balance*0.0975;
    }

}
