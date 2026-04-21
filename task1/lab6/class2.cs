public class StudentMarks : ThreeMarks
{
    public StudentMarks() : base(2, 2, 2, "") { }

    public StudentMarks(int a, int b, int c, string comment) : base(a, b, c, comment) { }

    public StudentMarks(StudentMarks other) : base(other) { }

    // проверка: сдал ли студент
    public bool IsPassed()
    {
        return FirstMark >= 3 && SecondMark >= 3 && ThirdMark >= 3;
    }

    // максимальная оценка
    public int GetMaxMark()
    {
        return Math.Max(FirstMark, Math.Max(SecondMark, ThirdMark));
    }

    // есть ли 5
    public bool HasExcellent()
    {
        return FirstMark == 5 || SecondMark == 5 || ThirdMark == 5;
    }

    public override string ToString()
    {
        return $"student marks: {FirstMark}, {SecondMark}, {ThirdMark}";
    }
}