﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JednokrotnyWybor.Presenter
{
    public interface IQuestionView
    {
        void ShowResult(bool isCorrect, string resultExplaination);
        string Question { set; }
        List<Answer> AnswersGiven { get; }
        List<Answer> Answers { get; set; } 
    }
}
