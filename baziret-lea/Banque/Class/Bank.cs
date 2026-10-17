class Bank
{
    //Note: On instancie 1 seule fois "Accounts" car il n'y a qu'un seule "dictionnaire" contenant les comptes.
    //          On le fait dans la classe "Banque" car on ne peut de toute facon pas l'instancier ailleurs, à cause de "private set".

    public Dictionary<string, CurrentAccount> Accounts { get; private set; } = new Dictionary<string, CurrentAccount>();
    public string? Name;

    public void AddAccount(CurrentAccount account)
    {
        //Note: Vérifier que le "number" n'est pas null, dans quel cas on ne le rajoute pas dans Accounts.
        if (account.Number == null)
        {
            System.Console.WriteLine("Numéro null");
            return;
        }
        Accounts.Add(account.Number, account);
    }
    public void DeleteAccount(string number)
    {
        Accounts.Remove(number);
    }

    //Permettre à la banque de donner la somme de tous les comptes d’une personne
    public double GetTotalSumAccount(Person owner)
    {
        double sum = 0;
        foreach (CurrentAccount account in Accounts.Values)
        {
            if (account.Owner == owner)
            {
                sum += account.Balance;
            }
        }
        return sum;
    }
}