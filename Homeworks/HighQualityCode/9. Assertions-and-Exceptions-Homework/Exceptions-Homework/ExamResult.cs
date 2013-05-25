using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade cannot be negative number.");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The min grade cannot be negative number.");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("The max grade can be bigger or equal to min grade.");
        }
        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("The comments are obligatory and cannot be null or empty string.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
