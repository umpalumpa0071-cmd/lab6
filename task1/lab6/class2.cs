using System.Xml.Linq;

public class StudentMarks : ThreeMarks
{
    private int _firstMark;
    private int _secondMark;
    private int _thirdMark;

    public StudentMarks() : this(2, 2, 2, "") { }

    public StudentMarks(int a, int b, int c, string comment) : base(comment)
    {
        _firstMark = a;
        _secondMark = b;
        _thirdMark = c;
    }

    public StudentMarks(StudentMarks other) : base(other)
    {
        _firstMark = other._firstMark;
        _secondMark = other._secondMark;
        _thirdMark = other._thirdMark;
    }

    public int FirstMark
    {
        get { return _firstMark; }
        set { _firstMark = value; }
    }

    public int SecondMark
    {
        get { return _secondMark; }
        set { _secondMark = value; }
    }

    public int ThirdMark
    {
        get { return _thirdMark; }
        set { _thirdMark = value; }
    }

    public double GetAverage()
    {
        return (_firstMark + _secondMark + _thirdMark) / 3.0;
    }

    public bool IsPassed()
    {
        return _firstMark >= 3 && _secondMark >= 3 && _thirdMark >= 3;
    }

    public int GetMaxMark()
    {
        return Math.Max(_firstMark, Math.Max(_secondMark, _thirdMark));
    }

    public override string ToString()
    {
        return $"marks: [{_firstMark}, {_secondMark}, {_thirdMark}], comment: {Comment}";
    }
}
