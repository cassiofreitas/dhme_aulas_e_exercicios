namespace Aula14Atividade1;

internal class Employee
{

    public string Nome { get; set; }     
    public string Sobrenome { get; set; }
    public string Telefone { get; set; }
    public decimal Salario { get; set; }
    public string CPF { get; set; }
    private bool Status = true;
    // Estágio do Funcionário - Ativo ou Inativo (true/false).
    public bool Estagio()
    {
        return Status;
    }
}
