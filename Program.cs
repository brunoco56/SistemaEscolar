using System;

namespace SistemaEscolar
{
    public class Program
    {     

        static void Main(string[] args)
        {

            int resposta = ObterOpcaoUsuario();

            while (resposta != 0)
            {
                switch (resposta)
                {

                    case 1:
                        Console.WriteLine("numero 1");
                        //codigo
                        break;
                    case 2:
                      
                        Console.WriteLine("numero 2");
                        //codigo
                        break;
                    case 3:
                      
                        Console.WriteLine("numero 3");
                        //codigo
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
