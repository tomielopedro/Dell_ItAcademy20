namespace Laboratorio4.ContentContext
{

    class Client
    {
        public Client(string? cpf, string? clientName)
        {
            Cpf = cpf;
            ClientName = clientName;
            ClientAccounts = new List<Account>();
        }

        public string? Cpf { get; }

        public string? ClientName { get; }

        public IList<Account> ClientAccounts { get; set; }

    }
}