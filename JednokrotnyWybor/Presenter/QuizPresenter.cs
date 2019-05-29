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

        public QuizPresenter(IQuizView view, QuizModel model)
        {
            this.view = view;
            this.model = model;

            view.LoadTestFromJson += View_LoadTestFromJson;
            view.PrepareResults += View_PrepareResults;
        }

        private void View_PrepareResults()
        {
            throw new NotImplementedException();
        }

        private void View_LoadTestFromJson(string path)
        {
            Test test = new Test();
            test.Author = "Marcin";
            test.Title = "Biolka";
            test.Description = "Krótki opis";
            Question question = new Question();
            question.Content = "Czemy kaczki mają zimne nogi?";
            Answer answer = new Answer();
            answer.Content = "nie wiem";
            answer.Points = 1;
            question.Answers.Add(answer);

            Question question2 = new Question();
            question.Content = "YTETDSF?";
            test.Questions.Add(question);

            view.Title = test.Title;
            view.Author = test.Author;
            view.Description = test.Description;

            view.Questions = new List<Question> { question, question2, question, question };
        }
    }
}
