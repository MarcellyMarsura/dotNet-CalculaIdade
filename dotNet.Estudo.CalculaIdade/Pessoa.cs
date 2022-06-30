namespace dotNet.Estudo.CalculaIdade
{
    internal class Pessoa
    {
        static int id;
        private string nome;
        private DateTime dataNascimento;

        public int Id { get; private set; }

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome inválido");
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get => dataNascimento;
            set
            {
                if (value >= DateTime.Now)
                    throw new Exception("Data inválida");
                dataNascimento = value;
            }
        }

        public int Idade { get; set; }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            id++;
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Idade = CalculaIdade();
        }

        private int CalculaIdade()
        {
            DateTime dataAtual = DateTime.Now;

            if(dataAtual.Month < DataNascimento.Month || (dataAtual.Month == DataNascimento.Month && dataAtual.Day < DataNascimento.Day))
            {
                return dataAtual.Year - DataNascimento.Year - 1;
            }

            return dataAtual.Year - DataNascimento.Year;
        }

        public override string ToString()
        {
            string texto = $"Id: {Id}" + Environment.NewLine
                         + $"Nome: {Nome}" + Environment.NewLine
                         + $"Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}" + Environment.NewLine
                         + $"Idade: {Idade} anos" + Environment.NewLine;
            return texto;
        }
    }
}
