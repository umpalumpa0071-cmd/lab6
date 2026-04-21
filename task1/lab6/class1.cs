using System;

public class ThreeMarks
{
    private int firstMark;
    private int secondMark;
    private int thirdMark;

    private string comment;

    // конструктор без параметров
    public ThreeMarks() : this(2, 2, 2, "") { }

    // основной конструктор
    public ThreeMarks(int a, int b, int c, string comment)
    {
        firstMark = a;
        secondMark = b;
        thirdMark = c;
        this.comment = comment;
    }

    // конструктор копирования
    public ThreeMarks(ThreeMarks other)
    {
        firstMark = other.firstMark;
        secondMark = other.secondMark;
        thirdMark = other.thirdMark;
        comment = other.comment;
    }

    public int FirstMark
    {
        get { return firstMark; }
        set { firstMark = value; }
    }

    public int SecondMark
    {
        get { return secondMark; }
        set { secondMark = value; }
    }

    public int ThirdMark
    {
        get { return thirdMark; }
        set { thirdMark = value; }
    }

    // метод добавляет !!! к комментарию
    public void AddExclamations()
    {
        comment = "!!!" + comment;
    }

    // средний балл
    public double GetAverage()
    {
        return (firstMark + secondMark + thirdMark) / 3.0;
    }

    public override string ToString()
    {
        return $"marks: [{firstMark}, {secondMark}, {thirdMark}], comment: {comment}";
    }
}