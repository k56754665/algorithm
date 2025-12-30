using System;

class Program {
    public static void Main(string[] args) {
        int[] answer = new int[2];
        
        for (int i = 0; i < 2; i++)
        {
            int[] score = new int[10];
            for (int j = 0; j < 10; j++)
            {
                score[j] = int.Parse(Console.ReadLine());
            }
            Array.Sort(score, (num1, num2) => num2.CompareTo(num1));
            answer[i] = score[0] + score[1] + score[2];
        }

        Console.WriteLine(answer[0] + " " + answer[1]);
    }
}