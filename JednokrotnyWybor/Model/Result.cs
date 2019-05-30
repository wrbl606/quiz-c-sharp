using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JednokrotnyWybor.Model
{
    public class Result
    {
        public bool IsCorrect { get; set; }
        public string Explaination { get; set; }

        public Result(bool IsCorrect, string Explaination)
        {
            this.IsCorrect = IsCorrect;
            this.Explaination = Explaination;
        }
    }
}
