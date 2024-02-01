using System;
public sealed class Stupenchatiy : Massive
{
   private int[][] mass;
  
   public override void GetMass()
   {
    Console.WriteLine("Вы создаете ступенчатый массив. Введите кол-во строк ");
    int n = int.Parse(Console.ReadLine());
    mass = new int[n][];
       Random random = new Random();
       for (int i = 0; i < n; i++)
       {
           int len = random.Next(0, 10);
           mass[i] = new int[len];
           for (int j = 0; j < len; j++)
           {
               int value = random.Next(0, 10);
               mass[i][j] = value;
           }
       }
   }
  
   public override void PrintMass()
   {
        Console.WriteLine(" ");
        int c = 0;
        for (int i = 0; i<mass.Length;i++)
        {
            foreach(int el in mass[i])
            {
                if (c != (mass[i].Length - 1))
                {
                    Console.Write($"{el}" + " ");
                    c++;
                }
                else
                {
                    Console.Write($"{el}" + "\n");
                    c = 0;
                }
            }
        }
        Console.WriteLine(" ");
   }
  
   public override void Average()
   {
        int sum = 0;
        int n = 0;
        foreach(int[] el in mass)
        {
            foreach(int i in el)
            {
                sum += i; 
                n+=1;
            }
        }
       Console.WriteLine($"Среднее значение списка: {sum / n}");
   
}
}