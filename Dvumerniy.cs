using System;
public sealed class Dvumerniy : Massive
{
   private int[,] mass;
  
   public override void GetMass()
   {
    Console.WriteLine("Вы создаете двумерный массив. Введите кол-во строк ");
    int m1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов");
    int m2 = int.Parse(Console.ReadLine());
        mass = new int[m1, m2];
        Random random = new Random();
        for (int i = 0; i < m1; i++)
          {
              for(int j =  0; j < m2; j++)
              {
                  mass[i, j] =  random.Next(0,10);
              }
          }
   }
  
   public override void PrintMass()
   {
        int c = 0;
        Console.WriteLine(" ");
        foreach(int el in mass)
            {
                if (c != (mass.GetLength(0) - 1))
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
            Console.WriteLine(" ");
        }
  
   public override void Average()
   {
        int sum = 0;
        foreach(int el in mass)
        {
                sum += el;
        }
       Console.WriteLine($"Среднее значение списка: {sum / mass.Length}");
       Console.WriteLine(" ");
   }
}