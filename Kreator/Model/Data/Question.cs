using System;
using System.Collections.Generic;

public class Question
{
    public string Content { get; set; }
    public List<Answer> Answers { get; } = new List<Answer>();
}
