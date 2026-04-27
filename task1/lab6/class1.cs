public class ThreeMarks
{
    private string comment;

    public ThreeMarks() : this("") { }

    public ThreeMarks(string comment)
    {
        this.comment = comment;
    }

    public ThreeMarks(ThreeMarks other)
    {
        comment = other.comment;
    }

    public string Comment
    {
        get { return comment; }
        set { comment = value; }
    }

    public void AddExclamations()
    {
        comment = "!!!" + comment;
    }

    public override string ToString()
    {
        return $"comment: {comment}";
    }
}
