namespace Laboratorio4.ContentContext
{

    class Bank
    {
        public Bank(string? name, int id)
        {
            Name = name;
            Id = id;
            Agencias = new List<Agencia>();
        }

        public string? Name { get; set; }
        public int Id { get; set; }

        public IList<Agencia> Agencias { get; set; }
    }



}