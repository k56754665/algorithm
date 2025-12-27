using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                Solution(str);
            }
        }

        public static void Solution(string str)
        {
            if (str.Length >= 6 && str.Length <= 9)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}