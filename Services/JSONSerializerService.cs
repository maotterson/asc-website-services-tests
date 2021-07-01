using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace razordemo.Services
{
    public class JSONSerializerService
    {
        public static object deserialize<T>(string stringData, T schema)
        {
            var data = JsonConvert.DeserializeAnonymousType(stringData, schema);
            return data;
        }
    }
}
