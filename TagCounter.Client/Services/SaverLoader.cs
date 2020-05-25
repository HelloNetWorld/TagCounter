using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;

namespace TagCounter.Client.Services
{
    public class SaverLoader
    {
        public static T Load<T>(string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        }

        public static void Save<T>(T obj, string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            File.WriteAllText(filePath, JsonConvert.SerializeObject(obj));
        }
    }
}
