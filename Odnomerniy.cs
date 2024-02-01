using System;
public sealed class Odnomerniy : Massive
{
   private int[] mass;

   public override void GetMass()
   {
    Console.WriteLine("Вы создаете одномерный массив. Введите количество элементнов ");
    int n = int.Parse(Console.ReadLine());
       mass = new int[n];
       Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            int val = random.Next(0,10);
            mass[i] = val;
        }
   }
  
   public override void PrintMass()
   {
       Console.WriteLine(" ");
       int n = mass.Length;
       for (int i = 0; i < n; i++)
       {
           Console.Write(mass[i] + " ");
       }
   }

   public override void Average()
   {
       int sum = 0;
       foreach(int el in mass)
    {
        sum += el;
    }
       Console.WriteLine($"Среднее значение в массиве: {sum / mass.Length}");
       Console.WriteLine(" ");
   }
}
