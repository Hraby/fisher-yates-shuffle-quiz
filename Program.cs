using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace fisher_yates
{
    internal class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[] list = { 1,2,3,4,5 };
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            int[] shuffle = Shuffle(list);
            Console.WriteLine();
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            
            Console.ReadKey();
        }

        public static int[] Shuffle(int[] list)
        {
            for (int i = list.Length-1; i >= 0; i--)
            {
                int j = rnd.Next(0, i);
                int temp = list[j];
                list[j] = list[i];
                list[i] = temp;
            }
            return list;
        }

        public static void questions(int volba)
        {
            switch (volba)
            {
                case 0:
                    Console.WriteLine("Nejvyšší hora světa?");
                    Console.WriteLine("a, Sněžka");
                    Console.WriteLine("b, Mount Everest");
                    Console.WriteLine("c, Mont Blanc");
                    break;
                case 1:
                    Console.WriteLine("Nejvyšší hora ČR?");
                    break;
                case 2:
                    Console.WriteLine("Nejdelší řeka světa?");
                    break;
                case 3:
                    Console.WriteLine("Nejmenší stát Evropy?");
                    break;
                case 4:
                    Console.WriteLine("Hlavní město ČR?");
                    break;
                default:
                    Console.WriteLine("nic");
                    break;
            }
        }
    }
}
