namespace curso_dotnet.poo
{
    public class BankAccount
    {
        private decimal balance;    // campo privado

        public decimal Balance    // propiedad pública de sólo lectura
        {
            get => balance;
            private set => balance = value;
        }

        public BankAccount(decimal initial)
        {
            Balance = initial;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Monto debe ser positivo");
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance) throw new InvalidOperationException("Fondos insuficientes");
            Balance -= amount;
        }
    }
}