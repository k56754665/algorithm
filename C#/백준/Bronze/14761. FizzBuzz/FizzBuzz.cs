using System;
using System.Linq;

class Program {
    public static void Main(string[] args) {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 1; i <= input[2]; i++)
        {
            bool fizz = false;
            bool buzz = false;
            
            if (i % input[0] == 0) fizz = true;
            if (i % input[1] == 0) buzz = true;

            if (fizz && buzz) Console.WriteLine("FizzBuzz");
            else if (fizz) Console.WriteLine("Fizz");
            else if (buzz) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
    }
}