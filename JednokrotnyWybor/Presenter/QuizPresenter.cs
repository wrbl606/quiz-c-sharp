using JednokrotnyWybor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JednokrotnyWybor.Presenter
{
    class QuizPresenter
    {
        readonly QuizModel model;
        readonly IQuizView view;
        private List<Question> questions;

        public QuizPresenter(IQuizView view, QuizModel model)
        {
            this.view = view;
            this.model = model;

            view.LoadTestFromJson += View_LoadTestFromJson;
            view.PrepareResults += View_PrepareResults;
        }

        private void View_PrepareResults()
        {
            List<List<Answer>> answers = view.Answers;
            List<Result> results = new List<Result>();
            for (int i = 0; i < answers.Count; i++)
            {
                int points = 0;
                foreach (Answer questionAnswer in answers[i])
                {
                    points += questionAnswer.Points;
                }
                results.Add(new Result(points >= 0, $"You've {(points >= 0 ? "earned" : "lost")} {points} on this question"));
            }

            view.ResultsExplaination = results;
        }

        private void View_LoadTestFromJson(string path)
        {
            Test test = model.LoadTest(path);
            questions = test.Questions;
            view.Questions = test.Questions;
        }
    }
}
