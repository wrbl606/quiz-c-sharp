using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JednokrotnyWybor.Presenter;

namespace JednokrotnyWybor
{
    public partial class QuestionView : UserControl, IQuestionView
    {
        List<Answer> answers = new List<Answer>();

        public QuestionView()
        {
            InitializeComponent();
        }

        public List<Answer> AnswersGiven {
            get
            {
                List<Answer> answersGiven = new List<Answer>();

                ListView.ListViewItemCollection items = AnswersList.Items;
                foreach (ListViewItem answerView in items)
                {
                    if (answerView.Checked)
                    {
                        Answer answer = answers.Find(answerData => answerData.Content.Equals(answerView.Text));
                        if (answer != null) answersGiven.Add(answer);
                    }
                }

                return answersGiven;
            }
        }

        public List<Answer> Answers
        {
            get => answers;

            set
            {
                answers = value;
                foreach (Answer answer in answers)
                {
                    AnswersList.Items.Add(answer.Content);
                }
            }
        }

        public string Question { set => QuestionContent.Text = value; }

        public void ShowResult(bool isCorrect, string resultExplaination)
        { 
            ResultExplaination.Text = resultExplaination;
            ResultExplaination.ForeColor = isCorrect ? Color.DarkGreen : Color.DarkRed;
        }
    }
}
