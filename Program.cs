using System;

namespace Praticando // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opc = ObterOpcao();

            while (opc != "4")
            {
                switch(opc) 
                {
                     //Inserir novo aluno
                    case "1":
                    Console.Write("Nome do aluno: ");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Nota do aluno: ");

                    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }
                    else
                    {
                        throw new ArgumentException("Valor da nota deve ser decimal");
                    }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        

                    break;

                    //Listar alunos
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (a.Nome != null)
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                            Console.ReadLine();
                        }


                    break;

                    case "3":
                    //Media geral dos alunos
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opc = ObterOpcao();
            }
        }

        static string ObterOpcao()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Media geral dos alunos");
            Console.WriteLine("4- Sair");
            Console.WriteLine();

            string opc = Console.ReadLine();
            Console.WriteLine();
            return opc;
        }
    }
}

