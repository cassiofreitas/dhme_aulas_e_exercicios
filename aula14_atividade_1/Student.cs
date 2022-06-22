namespace Aula14Atividade1;
internal class Student
{
    public string Matricula { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Telefone { get; set; }
    public Dictionary<int, double> Notas { get; set; } = new Dictionary<int, double> ();
    private bool Status = true;

    public void Atualizar_cadastro()
    {

    }
    public void Registrar_nota()
    {

    }
    public void Apresentar_notas()
    { 
    }
    public void Estágio_do_aluno()
    {
        return Status;
}
    public double Média_aluno()
    {
        var soma = 0.0;
         foreach (var item in Notas)
        {
            soma += item.Value;
        }
         return soma / 4; 
    }



}
