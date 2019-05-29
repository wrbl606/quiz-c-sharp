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

        public Answer Answer => throw new NotImplementedException();

        public List<Answer> Answers
        {
            get => answers;

            set
            {
                answers = value;
                foreach (Answer answer in answers)
                {
                    listView1.Items.Add(answer.Content);
                }
            }
        }

        public string Question { set => QuestionContent.Text = value; }

        public void ShowResult(bool isCorrect, string resultExplaination)
        {
            throw new NotImplementedException();
        }
    }
}
