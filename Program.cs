using System;

namespace dio_desafio_github_repositorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Inserir novo aluno");
                        break;
                    case "2":
                        Console.WriteLine("Listar alunos");
                        break;
                    case "3":
                        Console.WriteLine("Calcular média geral");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção invalida!");
                }

                Console.WriteLine("\nInforme a opção desejada: ");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                userOption = Console.ReadLine();
            }
        }
    }
}
