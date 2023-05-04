using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT2_AI
{
    /*
     * UDP 통신 시 편리한 데이터 변환
     */
    public static class Serializer
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
        };

        public static byte[] Serialize<T>(this T source)
        {
            var asString = JsonConvert.SerializeObject(source, SerializerSettings);
            return Encoding.Unicode.GetBytes(asString);
        }

        public static T Deserialize<T>(this byte[] source)
        {
            var asString = Encoding.Unicode.GetString(source);
            return JsonConvert.DeserializeObject<T>(asString);
        }
    }
}
