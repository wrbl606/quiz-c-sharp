using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JednokrotnyWybor
{
    public class JsonConverter
    {
        public static string Serialize(Test test)
        {
            return JsonConvert.SerializeObject(test);
        }

        public static Test Deserialize(string testJson) {
            return JsonConvert.DeserializeObject<Test>(testJson);
        }
    }
}
