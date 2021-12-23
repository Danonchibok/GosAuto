using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheBestProjectInTheWorld.Core
{
    internal class Serializer
    {
        public static int GetTimeInSeconds()
        {
            int time = JsonConvert.DeserializeObject<int>(File.ReadAllText(Environment.CurrentDirectory + "\\time.json"));
            return time;
        }

        public static void SetTimeInSeconds(int time)
        {
            string json = JsonConvert.SerializeObject(time);
            string path = Environment.CurrentDirectory + "\\time.json";
            File.WriteAllText(path, json);
        }
    }
}
