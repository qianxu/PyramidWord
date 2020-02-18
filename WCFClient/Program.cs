using System;

namespace WCFClient
{
    /// <summary>
    /// Test pyramid word service.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Test();

            //Test1();
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
