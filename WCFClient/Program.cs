using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace WCFClient
{
    /// <summary>
    /// Test pyramid word service.
    /// </summary>
    class Program
    {
        public const string ServerUrl = "http://localhost:38955/PyramidWordService.svc/ispyramidword?word={0}";
        static void Main(string[] args)
        {
            TestHttpRequest("aaabbc");
            TestHttpRequest("aaabbcc");
            Console.ReadLine();

            //Test();

            //Test1();
        }

        private static void TestHttpRequest(string word)
        {
            try
            {
                WebRequest request = WebRequest.Create(string.Format(ServerUrl, word));
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                dynamic result = JsonConvert.DeserializeObject(responseFromServer);
                bool isPyramidWord = result["d"];
                Console.WriteLine(string.Format("{0} is{1} pyramid word.",
                    word,
                    isPyramidWord ? "" : " not"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Test()
        {
            PyramidWordClient client = new PyramidWordClient();
            string input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(string.Format("{0} is{1} pyramid word.",
                    input,
                    client.IsPyramidWordAsync(input).Result ? "" : " not"));
                input = Console.ReadLine();
            }
        }

        private static void Test1()
        {
            PyramidWordClient client = new PyramidWordClient();
            string[] words = new string[]
            {
                "banana",
                "Banana",
                "Ban ana",
                "zzaaab",
                null,
                "baNana",
                " ",
                "",
                "kkkkk*",
                "b(>>>("
            };
            foreach (string word in words)
            {
                Console.WriteLine(string.Format("{0} is{1} pyramid word.",
                    word,
                    client.IsPyramidWordAsync(word).Result ? "" : " not"));
            }
            Console.ReadLine();
        }
    }
}
