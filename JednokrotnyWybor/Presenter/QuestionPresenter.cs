using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JednokrotnyWybor.Presenter
{
    public class QuestionPresenter
    {
        public IQuestionView View { get; }

        public QuestionPresenter(IQuestionView view)
        {
            View = view;
        }
    }
}
