using System;

namespace ValidacaoAposentadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu e-mail: ");
            string usuario = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            if (usuario == "haruo.fiap@gmail.com" && senha == "97663")
            {
                Console.WriteLine("Login bem-sucedido!\n");
                Console.Write("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Digite seu tempo de contribuição: ");
                int tempoContribuicao = int.Parse(Console.ReadLine());

                int idadeMinima = 65, tempoMinimo = 15;
                Console.Write("Digite seu sexo (M/F): ");
                char sexo = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (sexo == 'F') idadeMinima = 62;

                Console.WriteLine(idade >= idadeMinima && tempoContribuicao >= tempoMinimo ? "Parabéns! Você já pode se aposentar." :
                                  $"Faltam {Math.Max(0, idadeMinima - idade)} anos para idade mínima e {Math.Max(0, tempoMinimo - tempoContribuicao)} anos de contribuição.");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos.");
            }
            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
