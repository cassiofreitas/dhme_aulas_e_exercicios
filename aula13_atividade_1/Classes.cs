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
        public string Nome;
        public string Sobrenome;
        public int telefone;
    }
    internal class Escola
    {
        private Dictionary<int,Aluno> Matriculados = new Dictionary<int, Aluno>();
        public void CadastrarAluno()
        {
            Aluno NossoAluno = new Aluno();
            NossoAluno.Matricula = 1;
            NossoAluno.Nome = "Maria";
            NossoAluno.Sobrenome = "Jose";
            NossoAluno.telefone = 99995555;

            Matriculados.TryAdd(0, NossoAluno);
        }
        public void RemoverAluno()
        {
            Matriculados.Remove(0);
        }
        public void ListarMatriculas()
        {

        }
    }
}
