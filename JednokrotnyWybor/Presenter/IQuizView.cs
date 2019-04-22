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
        List<Question> Questions { set; }
        List<Answer> Answers { get; }
        List<string> ResultsExplaination { set; }
    }
}
