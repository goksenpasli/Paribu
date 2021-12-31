using Newtonsoft.Json;

namespace Paribu
{
    public static class Serialize
    {
        public static string ToJson(this MainViewModel self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }
}