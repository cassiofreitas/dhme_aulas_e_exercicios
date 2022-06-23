namespace Aula15Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ChoiceExit = 'N';
            double ValorMoedaConverterDe = 0;
            double ValorMoedaConvertida = 0;
            int MoedaConverterDe;
            int MoedaConverterPara;
            do
            {
                Console.Clear();
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Últimas 5 conversões:\n");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA"); // tem uma classe ou método que só faz isso
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
                Console.WriteLine("------------------------");
                Console.WriteLine("Moedas disponíveis para conversão:"); //adicionar aqui o return do método
                Console.WriteLine($"-----");
                Console.Write("Converter de: ");
                int.TryParse(Console.ReadLine(), out MoedaConverterDe);   //organizar um menu do tipo 1-BRL, 2-USD etc
                Console.Write("\tPara: ");
                int.TryParse(Console.ReadLine(), out MoedaConverterPara);   //organizar um menu do tipo 1-BRL, 2-USD etc
                Console.WriteLine("\n----");
                Console.WriteLine("Resultado da conversão: ");  //aqui vai o resultado do método da conversão
                Console.WriteLine("Conversão de xxx\t\tpara yyyy");
                Console.WriteLine("Valor a converter: zzz\t\tResultado da conversão: www\n");
                Console.WriteLine("Por favor, leia os resultados da conversão.");
                Console.WriteLine("----");
                Console.Write($"[ S ] para SAIR >");
                char.TryParse(Console.ReadLine(), out ChoiceExit);
            } while (char.ToUpper(ChoiceExit) is not 'S');
        }
    }
}