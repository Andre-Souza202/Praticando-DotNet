using System;
using System.Threading.Tasks;

namespace Praticando // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            //Aluno[] alunos = new Aluno[5];
            string opc = ObterOpcao();

            while (opc != "5")
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

                        alunos.Add(aluno);              

                    break;

                    case "2":

                    Console.Write("Nome do aluno a ser excluido: ");
                    var exAluno = Console.ReadLine();

                        for (int i = 0; i < alunos.Count; i++) 
                    {
                            if (alunos[i].Nome == exAluno)
                        {
                            alunos.Remove(alunos[i]);
                        }
                    }

                    break;

                    //Listar alunos
                    case "3":
                        foreach (var a in alunos)
                        {
                            if (a.Nome != null)
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        Console.WriteLine();


                    break;

                    //Media geral dos alunos
                    case "4":
                    decimal notaTotal = 0;
                    var nmAlunos = 0;

                    foreach (Aluno nAluno in alunos) 
                    {
                        notaTotal = notaTotal + nAluno.Nota;
                        nmAlunos++;
                    }

                    var media = notaTotal / nmAlunos;
                    Conceito conceitoGeral;

                    if (media <= 2)
                    {
                        conceitoGeral = Conceito.E;
                    }
                    else if (media <= 4)
                    {
                        conceitoGeral = Conceito.D;
                    }
                    else if (media <= 6)
                    {
                        conceitoGeral = Conceito.C;
                    }
                    else if (media <= 8)
                    {
                        conceitoGeral = Conceito.B;
                    }
                    else
                    {
                        conceitoGeral = Conceito.A;
                    }

                    Console.WriteLine($"Média geral: {media} - Conceito geral: {conceitoGeral}");
                    Console.WriteLine();

                    break;

                    default:
                        Console.WriteLine("Por favor digite um numero de 1 a 5 ");
                        Console.WriteLine();
                    break;
                }
                opc = ObterOpcao();
            }
        }

        static string ObterOpcao()
        {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Excluir aluno");
            Console.WriteLine("3- Listar alunos");
            Console.WriteLine("4- Media geral dos alunos");
            Console.WriteLine("5- Sair");
            Console.WriteLine();

            string opc = Console.ReadLine();
            Console.WriteLine();
            return opc;
        }
    }
}

