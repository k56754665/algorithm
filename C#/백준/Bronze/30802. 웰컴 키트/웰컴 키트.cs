using System;

class Program {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] sizes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] line3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int t = line3[0];
        int p = line3[1];

        // 티셔츠
        int tshirts = 0;
        foreach (int size in sizes)
        {
            int bundle = size / t;
            if (size % t != 0) bundle += 1;
            tshirts += bundle;
        }

        Console.WriteLine(tshirts);

        // 펜
        Console.WriteLine(n / p + " " + n % p);
    }
}