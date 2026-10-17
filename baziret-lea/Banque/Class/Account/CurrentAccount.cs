
    class CurrentAccount : Account
    {
        public double CreditLine;

        //Il n'est pas nécessaire de mettre un paramètre dans la méthode, car la méthode traite déjà le "current account".
        public double GetBalance()
        {
            return Balance;
        }

    }
