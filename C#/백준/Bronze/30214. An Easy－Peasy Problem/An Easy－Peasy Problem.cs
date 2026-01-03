using System;


class Program {
    public static void Main(string[] args) {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int s1 = input[0];
        int s2 = input[1];

        string answer = (s1 * 2 >= s2) ? "E" : "H";
        Console.WriteLine(answer);
    }
}