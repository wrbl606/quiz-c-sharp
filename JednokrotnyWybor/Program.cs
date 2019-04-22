using JednokrotnyWybor.Model;
using JednokrotnyWybor.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JednokrotnyWybor
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            QuizModel model = new QuizModel();
            IQuizView view = new Form1();
            QuizPresenter presenter = new QuizPresenter(view, model);

            Application.Run((Form) view);
        }
    }
}
