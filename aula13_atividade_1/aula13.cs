using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_atividade_1
{
    enum CatalogoErros
    {
        OK = 200,
        Redirecionamento_permanent = 301,
        Redirecionamento_temporario = 302,
        Nao_encontrado = 404,
        Nao_autorizado = 405,
        Servidor_indisponivel = 503,
        Tempo_esgotado = 504
    }
    internal class aula13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}