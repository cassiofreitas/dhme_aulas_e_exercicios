namespace Aula14Atividade1;

internal class Student
{
    public string Registration { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public double[] Grades { get; set; } = new double[4];

    public void Update()
    {

    }
    public void SetGrade(int bimester, double grade)
    {

    }

    public void ShowGrades()
    {
    }

    public bool IsApproved()
    {
        return AverageGrade() > 6;
    }

    public double AverageGrade()
    {
        var sum = 0.0;

        foreach (var grade in Grades)
            sum += grade;

        return sum / 4;
    }
}
