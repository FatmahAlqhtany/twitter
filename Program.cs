using System;

namespace Fatimah
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "#طويق #الاتحاد السعودي @حساب @الاتحاد";
            Tokenizer(s);
        }
        static void Tokenizer(string twitter)
        {
            int countHash = 0;
            int countAt = 0;

            foreach (String item in twitter.Split(' '))
            {
                if (item.StartsWith("#") || item.StartsWith("@"))
                {
                    Console.WriteLine(item);
                    if (item.StartsWith("#"))
                    {
                        countHash++;
                    }
                    else if (item.StartsWith("@"))
                    {
                        countAt++;
                    }
                }
            }
            Console.WriteLine("The number of hashtags: " + countHash);
            Console.WriteLine("The number of mentions: " + countAt);
        }
    }
}
