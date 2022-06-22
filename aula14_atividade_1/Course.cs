using Aula14Atividade1.Abstractions;

namespace Aula14Atividade1;

internal class Course : Administration<Student>
{
    public override bool Register(Student entity)
    {
        throw new NotImplementedException();
    }

    public override bool Remove(Student entity)
    {
        throw new NotImplementedException();
    }

    public override bool Update(Student entity)
    {
        throw new NotImplementedException();
    }

    public override IReadOnlyList<Student> List()
    {
        throw new NotImplementedException();
    }
}
