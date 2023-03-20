using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {//отсортировать одномерный масссив по возрастанию
         // первый способ
            int[] mass = {-8,6,0,11,4,-4,3};
            int i;
            for (i=0;i<mass.Length-1;i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        int p = mass[i];
                        mass[i] = mass[j];
                        mass[j] = p;
                    }
                }               
            }
            //for(int i = 0; i < mass.Length; i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            foreach( int a in mass)
            {
                Console.WriteLine($"{a}");
            }
            Console.Read();
        }
    }
}
