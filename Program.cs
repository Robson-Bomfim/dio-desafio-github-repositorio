using System;
using System.Globalization;
using System.Collections.Generic;

namespace dio_desafio_github_repositorio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Student student = new Student();
                        Console.WriteLine("Informe o nome do aluno");
                        student.Name = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno");

                        if (double.TryParse(Console.ReadLine(), out double grade))
                        {
                            student.Grade = grade;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser double!");
                        }

                        students.Add(student);
                        break;
                    case "2":
                        Console.WriteLine("Lista de alunos: ");
                        Console.WriteLine();
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Nenhum aluno cadastrado.");
                        }
                        else
                        {
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"ALUNO: {s.Name} - NOTA: {s.Grade}");
                                }
                            }
                        }
                        break;
                    case "3":
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Nenhum aluno cadastrado.");
                        }
                        else
                        {
                            double amount = 0.0;
                            Console.WriteLine("Calculando média geral...");
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    amount = amount + s.Grade;
                                }
                            }

                            double average = amount / students.Count;
                            Concept concept = GetConcept(average);

                            Console.WriteLine($"MEDIA GERAL: {average.ToString("F2", CultureInfo.InvariantCulture)} - CONCEITO: {concept}");
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção invalida!");
                }

                userOption = GetUserOption();
            }
        }

        private static Concept GetConcept(double average)
        {
            Concept Concept;
            if (average <= 2)
            {
                Concept = Concept.E;
            }
            else if (average <= 4)
            {
                Concept = Concept.D;
            }
            else if (average <= 6)
            {
                Concept = Concept.C;
            }
            else if (average <= 8)
            {
                Concept = Concept.B;
            }
            else
            {
                Concept = Concept.A;
            }

            return Concept;
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            return Console.ReadLine();
        }
    }
}
