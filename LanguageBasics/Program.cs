using System;

namespace LanguageBasics
{
    static class Util
    {
        public static int a = 5;

        public static string Reverse(this string s)
        {
            string res = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                res += s[i];
            }
            return res;
        }
    }
    class Program
    {
        static public int X { get; set; }
        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string name = "Peter";

            //string res = Util.Reverse(name);

            string res = name.Reverse();

            Console.WriteLine(res);

            return;

            Program.X = 5;

            var a = 5;
            var b = 6;

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a} and b = {b}");

        }
    }
}
