using JednokrotnyWybor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JednokrotnyWybor.Presenter
{
    interface IQuizView
    {
        event Action<string> LoadTestFromJson;
        // show PASS/FAIL message with counted points
        event Action PrepareResults;
        string Title { set; }
        string Author { set; }
        string Description { set; }
        List<Question> Questions { set; }
        List<List<Answer>> Answers { get; }
        List<Result> ResultsExplaination { set; }
    }
}
