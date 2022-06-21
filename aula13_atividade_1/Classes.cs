using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_atividade_1
{
    public class Aluno
    {
        public int Matricula;
        public string? Nome;
        public string? Sobrenome;
        public int Telefone;
    }
    internal class Escola
    {
        private Dictionary<int,Aluno> Matriculados = new Dictionary<int, Aluno>();
        public void CadastrarAluno(int NumeroMatricula, string? Nome, string? Sobrenome, int Telefone)
        {
            Aluno NossoAluno = new Aluno();
            NossoAluno.Matricula = NumeroMatricula;
            NossoAluno.Nome = Nome;
            NossoAluno.Sobrenome = Sobrenome;
            NossoAluno.Telefone = Telefone;

            Matriculados.TryAdd(Matriculados.Count(), NossoAluno);
        }
        public void RemoverAluno()
        {
            Matriculados.Remove(0);
        }
        public void ListarMatriculas()
        {
            Console.WriteLine(Matriculados[0].Nome);
        }
    }
}
