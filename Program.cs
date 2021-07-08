using System;

namespace SistemaEscolar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            int resposta = ObterOpcaoUsuario();

            while (resposta != 0)
            {
                switch (resposta)
                {

                    case 1:
                        Console.WriteLine("Informe o nome do Aluno: ");

                        Aluno aluno = new Aluno();

                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }

                        else
                        {
                            throw new ArgumentException("Valores da nota estão incorretos, favor inserir um valor decimal.");
                        }

                        alunos[indiceAluno] = aluno;

                        indiceAluno++;

                        break;
                    case 2:
                        foreach (var item in alunos)
                        {
                            if (item.Nome != null)
                            {
                                Console.WriteLine($"Aluno {item.Nome}, Nota: {item.Nota}");
                            }
                        }

                        Console.WriteLine("numero 2");

                        break;
                    case 3:
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (alunos[i].Nome != null)
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;

                        Conceito conceitoGeral;
                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;

                        }

                        Console.WriteLine($"Média Geral é de {mediaGeral}, e o conceito é de: {conceitoGeral}");

                        break;

                    default:

                        throw new ArgumentOutOfRangeException();
                }

                resposta = ObterOpcaoUsuario();
            }
        }

        private static int ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Inserir Novo Aluno.");
            Console.WriteLine("2 - Listar Alunos.");
            Console.WriteLine("3 - Calcular média Geral.");
            Console.WriteLine("0 - Sair ");
            Console.WriteLine("-------------------------------");
            int resposta = int.Parse(Console.ReadLine());
            return resposta;
        }
    }
}