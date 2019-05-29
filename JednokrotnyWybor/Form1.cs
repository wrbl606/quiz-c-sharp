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
                }

        } }

        public List<Answer> Answers => throw new NotImplementedException();

        public List<string> ResultsExplaination { set => throw new NotImplementedException(); }
        public string Title { set => TestTitle.Text = value; }
        public string Author { set => TestAuthor.Text = value; }
        public string Description { set => TestDescription.Text = value; }

        public event Action<string> LoadTestFromJson;
        public event Action PrepareResults;

        private void TestTitle_Click(object sender, EventArgs e)
        {

            LoadTestFromJson("test");
        }
    }
}
