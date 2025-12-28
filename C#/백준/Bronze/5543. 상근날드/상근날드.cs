using System;

class Program {
    public static void Main(string[] args) {
        int[] burgers = new int[3];
        int[] beverages = new int[2];
        int burgerMin;
        int beverageMin;

        for (int i = 0; i < 3; i++)
        {
            burgers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 2; i++)
        {
            beverages[i] = int.Parse(Console.ReadLine());
        }

        burgerMin = burgers[0];
        beverageMin = beverages[0];
        foreach(int item in burgers)
        {
            if (burgerMin > item)
            {
                burgerMin = item;
            }
        }
        foreach(int item in beverages)
        {
            if (beverageMin > item)
            {
                beverageMin = item;
            }
        }
        Console.WriteLine(burgerMin+beverageMin-50);
    }
}
