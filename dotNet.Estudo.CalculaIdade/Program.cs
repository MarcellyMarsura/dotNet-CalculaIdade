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
                Console.WriteLine("\nS para sair ou qualquer tecla para continuar...");
            } while (Console.ReadKey().Key != ConsoleKey.S);

            ExibirCadastros();  
        }

        static void NovoCadastro()
        {
            Console.Clear();
            Console.WriteLine("NOVO CADASTRO:");
            do
            {
                try
                {
                    EntradaDeDados();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERRO: {e.Message}");
                }
            } while (true); 
        }

        static void EntradaDeDados()
        {
            Console.Write("\nNome: ");
            var nome = Console.ReadLine().Trim();

            Console.Write("Data de Nascimento: ");
            var dataNascimento = Convert.ToDateTime(Console.ReadLine());

            var p = new Pessoa(nome: nome,
                           dataNascimento: dataNascimento);

            pessoas.Add(p);
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
