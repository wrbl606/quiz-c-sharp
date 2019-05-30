using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JednokrotnyWybor.Model
{
    class QuizModel
    {
        public Test LoadTest(string filePath)
        {
            string text = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Test>(text);
        }
    }
}
