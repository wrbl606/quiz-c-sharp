using JednokrotnyWybor.Model;
using JednokrotnyWybor.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JednokrotnyWybor
{
    public partial class Form1 : Form, IQuizView
    {
        List<QuestionPresenter> questionViews = new List<QuestionPresenter>();

        public Form1()
        {
            InitializeComponent();
        }

        public List<Question> Questions { set {
            foreach (Question question in value)
                {
                    IQuestionView view = new QuestionView();
                    QuestionPresenter presenter = new QuestionPresenter(view);
                    QuestionsList.Controls.Add((QuestionView)view);
                    presenter.View.Question = question.Content;
                    presenter.View.Answers = question.Answers;
                    questionViews.Add(presenter);
                }

        } }

        public List<List<Answer>> Answers {
            get
            {
                List<List<Answer>> answersGiven = new List<List<Answer>>();
                foreach (var questionPresenter in questionViews)
                {
                    answersGiven.Add(questionPresenter.View.AnswersGiven);
                }
                Console.WriteLine($"All answers given: {answersGiven.Count()}");
                return answersGiven;
            }
        }

        public List<Result> ResultsExplaination { set {
                for (int i = 0; i < value.Count(); i++)
                {
                    Result result = value[i];
                    questionViews[i].View.ShowResult(result.IsCorrect, result.Explaination);
                }
            } }
        public string Title { set => TestTitle.Text = value; }
        public string Author { set => TestAuthor.Text = value; }
        public string Description { set => TestDescription.Text = value; }

        public event Action<string> LoadTestFromJson;
        public event Action PrepareResults;

        private void FinishQuizButton_Click(object sender, EventArgs e)
        {
            PrepareResults();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadTestFromJson(openFileDialog.FileName);
                }
            }
        }
    }
}
