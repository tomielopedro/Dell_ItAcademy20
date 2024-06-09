namespace Laboratorio4.ContentContext
{

    class Account
    {
        public Account(int accountNum, Bank? accountBank, Agencia? accountAgency, Client? accountClient, decimal accountInitialValue)
        {
            AccountNum = accountNum;
            AccountBank = accountBank;
            AccountAgency = accountAgency;
            AccountClient = accountClient;
            AccountInitialValue = accountInitialValue;
            saldo = AccountInitialValue;
        }

        public int AccountNum { get; }
        public Bank? AccountBank { get; }

        public Agencia? AccountAgency { get; }

        public Client? AccountClient { get; }

        public decimal AccountInitialValue { get; }

        private decimal saldo;

        public decimal Saldo => saldo;


        public void Sacar(decimal value)
        {
            saldo -= value;
        }

        public void Depositar(decimal value)
        {
            saldo += value;
        }




    }

}