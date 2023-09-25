using System.Text.Json;

namespace RestfulBookerApi
{
    internal class Utility
    {
        public static T ParseJSon<T>(string fileName)
        {
            string jsonString = File.ReadAllText(GetFilePath(fileName));
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        public static string GetFilePath(string name)
        {
            return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", name));
        }
    }
}
