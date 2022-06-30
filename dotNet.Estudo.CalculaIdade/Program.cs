namespace dotNet.Estudo.CalculaIdade
{
    public class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        
        public static void Main(String[] args)
        {
            do
            {
                NovoCadastro();
            } while (Console.ReadKey().Key != ConsoleKey.S);

            ExibirCadastros();  
        }

        static void NovoCadastro()
        {
            string nome;
            DateTime dataNascimento;
            Pessoa p;
            Console.Clear();
            Console.WriteLine("NOVO CADASTRO:");
            do
            {
                try
                {
                    Console.Write("\nNome: ");
                    nome = Console.ReadLine().Trim();

                    Console.Write("Data de Nascimento: ");
                    dataNascimento = Convert.ToDateTime(Console.ReadLine());

                    p = new Pessoa(nome: nome,
                                   dataNascimento: dataNascimento);

                    pessoas.Add(p);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERRO: {e.Message}");
                }
            } while (true);


            Console.WriteLine("\nAperte S para sair ou qualquer tecla para continuar...");
        }

        static void ExibirCadastros()
        {
            Console.Clear();
            Console.WriteLine("PESSOAS CADASTRADAS:\n");

            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
