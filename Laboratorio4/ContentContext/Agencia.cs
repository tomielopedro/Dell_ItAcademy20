namespace Laboratorio4.ContentContext
{

    class Agencia
    {
        public Agencia(Bank? bankAgencia, int idAgencia)
        {
            BankAgencia = bankAgencia;
            IdAgencia = idAgencia;
            Clients = new List<Client>();
        }

        public Bank? BankAgencia { get; }

        public int IdAgencia { get; }

        public IList<Client> Clients { get; set; }


    }



}