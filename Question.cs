using System;
using System.Collections.Generic;

public class Question
{
    public string Content { get; set; }
    public decimal CorrectAnswerPoints { get; set; } = 1;
    public decimal IncorrectAnswerPoints { get; set; } = -1;
    public List<Answer> Answers { get; } = new List<Answer>();
}
