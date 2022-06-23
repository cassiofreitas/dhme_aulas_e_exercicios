namespace Aula14Atividade1;

internal class Program
{
    private static void Main()
    {
        int MenuOptionChoice = 0;
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("\n-[ ALUNO ]-\n");
            Console.WriteLine("(1) Cadastrar aluno");
            Console.WriteLine("(3) Remover aluno");
            Console.WriteLine("(5) Atualizar cadastro aluno");
            Console.WriteLine("(7) Lançar notas de alunos");
            Console.WriteLine("(8) Listar notas de alunos");
            Console.WriteLine("(9) Listar média das notas de aluno");
            Console.WriteLine("(10) Mostrar situação do estágio do aluno");
            Console.WriteLine("\n-[ FUNCIONÁRIO ]-\n");
            Console.WriteLine("(2) Cadastrar funcionário");
            Console.WriteLine("(4) Remover funcionário");
            Console.WriteLine("(6) Atualizar cadastro funcionário");
            Console.WriteLine("(11) Mostrar situação do estágio do funcionário");
            Console.WriteLine("\n-[ Inscritos ]-\n");
            Console.WriteLine("(12) Listar todos os inscritos [ alunos e funcionários ]");
            //Get out.
            Console.WriteLine("\n(13) Sair");
            //
            int.TryParse(Console.ReadLine(), out MenuOptionChoice);
            //
            switch (MenuOptionChoice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    MenuOptionChoice = 0;
                    break;
            }
        } while (MenuOptionChoice is < 1 or > 13);
    }
}