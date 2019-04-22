using System;
using System.Collections.Generic;

public class Test
{
    public string Title { get; set; }
	public string Description { get; set; }
    public string Author { get; set; }
    public List<Question> Questions { get; } = new List<Question>();
}
